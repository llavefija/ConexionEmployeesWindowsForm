using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionEmployeesWondowsForm
{
    public partial class ListaTrabajos : Form
    {
        private DataBase db; // Instancia de la clase DataBase

        private ToolTip toolTip;

        private ContextMenuStrip contextMenuStrip = new ContextMenuStrip();

        internal ListaTrabajos(DataBase Db)
        {
            InitializeComponent();
            this.db = Db;
            db.ConnectDB();

            // Inicializar ToolTip
            toolTip = new ToolTip();

            // Configurar ToolTip para un botón específico
            toolTip.SetToolTip(buttonBorrarCampos, "Vacia todos los campos.");
            toolTip.SetToolTip(buttonGuardar, "Guarda los cambios en la BD.");
            toolTip.SetToolTip(buttonMenu, "Regresa al menú principal.");
            toolTip.SetToolTip(buttonBuscar, "Actualiza la tabla.");

            // Desactivar el botón Guardar inicialmente
            buttonGuardar.Enabled = false;

            // Agregar evento para verificar datos en tiempo real
            dataGridViewJobs.CellValueChanged += DataGridViewJobs_CellValueChanged;
            dataGridViewJobs.RowValidating += DataGridViewJobs_RowValidating;

            CargarTrabajos();
        }

        private void DataGridViewJobs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Cada vez que cambia una celda, verifica la validez de la fila
            VerificarFila(dataGridViewJobs.Rows[e.RowIndex]);
            VerificarHabilitarGuardar();
        }

        private void DataGridViewJobs_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Asegura la validez de la fila cuando se intenta salir de ella
            VerificarFila(dataGridViewJobs.Rows[e.RowIndex]);
            VerificarHabilitarGuardar();
        }

        private void VerificarFila(DataGridViewRow row)
        {
            bool filaValida = true;
            string mensajeError = "";

            // Obtener los valores de cada celda y verificar que no estén vacíos
            var jobTitleCell = row.Cells["job_title"].Value;
            var minSalaryCell = row.Cells["min_salary"].Value;
            var maxSalaryCell = row.Cells["max_salary"].Value;

            // Si alguna de las celdas es nula o vacía, omitir la validación completa
            if (jobTitleCell == null || minSalaryCell == null || maxSalaryCell == null ||
                string.IsNullOrWhiteSpace(jobTitleCell.ToString()) ||
                string.IsNullOrWhiteSpace(minSalaryCell.ToString()) ||
                string.IsNullOrWhiteSpace(maxSalaryCell.ToString()))
            {
                row.DefaultCellStyle.BackColor = Color.LightYellow; // Indicar que está incompleta
                row.ErrorText = "Completa todos los campos para validar esta fila. Si se deja vacia se eliminara al guardar.";
                filaValida = true;  // Se marca como válida
            }
            else
            {
                // Obtener los valores completos de cada celda después de verificar que existen
                string jobTitle = jobTitleCell.ToString();
                decimal minSalary = Convert.ToDecimal(minSalaryCell);
                decimal maxSalary = Convert.ToDecimal(maxSalaryCell);

                // Validaciones de negocio
                if (string.IsNullOrWhiteSpace(jobTitle))
                {
                    filaValida = false;
                    mensajeError = "El título del trabajo no puede estar vacío.";
                }
                else if (minSalary < 0)
                {
                    filaValida = false;
                    mensajeError = "El salario mínimo debe ser mayor o igual a cero.";
                }
                else if (maxSalary < 0)
                {
                    filaValida = false;
                    mensajeError = "El salario máximo debe ser mayor o igual a cero.";
                }
                else if (minSalary > maxSalary)
                {
                    filaValida = false;
                    mensajeError = "El salario mínimo no puede ser mayor que el salario máximo.";
                }

                // Cambiar el color de fondo según la validez de la fila
                row.DefaultCellStyle.BackColor = filaValida ? Color.LightGreen : Color.LightCoral;
                row.ErrorText = filaValida ? "" : mensajeError;
            }
        }

        private void VerificarHabilitarGuardar()
        {
            // Verifica todas las filas para asegurar que no haya errores
            bool habilitarGuardar = true;

            foreach (DataGridViewRow row in dataGridViewJobs.Rows)
            {
                // Ignorar la fila nueva
                if (row.IsNewRow) continue;

                // Si alguna fila tiene un error, no habilitar el botón
                if (!string.IsNullOrEmpty(row.ErrorText))
                {
                    habilitarGuardar = true;
                    break;
                }

                // Verificar que las celdas tienen valores válidos
                var jobTitleCell = row.Cells["job_title"].Value;
                var minSalaryCell = row.Cells["min_salary"].Value;
                var maxSalaryCell = row.Cells["max_salary"].Value;

                if (jobTitleCell == null || minSalaryCell == null || maxSalaryCell == null ||
                    string.IsNullOrWhiteSpace(jobTitleCell.ToString()) ||
                    string.IsNullOrWhiteSpace(minSalaryCell.ToString()) ||
                    string.IsNullOrWhiteSpace(maxSalaryCell.ToString()))
                {
                    habilitarGuardar = false;
                    break;
                }
            }

            // Habilitar o deshabilitar el botón de guardado
            buttonGuardar.Enabled = habilitarGuardar;
        }


        // Método para cargar los trabajos de la base de datos
        private void CargarTrabajos(string jobTitle = "", string minSalaryCondition = "=", decimal? minSalary = null, string maxSalaryCondition = "=", decimal? maxSalary = null)
        {
            try
            {
                // Crear la consulta SQL
                string query = "SELECT job_id, job_title, min_salary, max_salary FROM Jobs WHERE 1=1";

                // Agregar filtros a la consulta
                if (!string.IsNullOrEmpty(jobTitle))
                {
                    query += " AND job_title LIKE @job_title";
                }
                if (minSalary.HasValue)
                {
                    query += $" AND min_salary {minSalaryCondition} @min_salary";
                }
                if (maxSalary.HasValue)
                {
                    query += $" AND max_salary {maxSalaryCondition} @max_salary";
                }

                using (SqlCommand command = new SqlCommand(query, db.ReturnConecction()))
                {
                    // Agregar parámetros
                    if (!string.IsNullOrEmpty(jobTitle))
                    {
                        command.Parameters.AddWithValue("@job_title", "%" + jobTitle + "%");
                    }
                    if (minSalary.HasValue)
                    {
                        command.Parameters.AddWithValue("@min_salary", minSalary.Value);
                    }
                    if (maxSalary.HasValue)
                    {
                        command.Parameters.AddWithValue("@max_salary", maxSalary.Value);
                    }

                    // Llenar el DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    dataGridViewJobs.DataSource = dataTable;
                    dataGridViewJobs.Columns["job_id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los trabajos: {ex.Message}");
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            // Obtener el texto del TextBox de búsqueda y salarios
            string titleFilter = textBoxTitle.Text.Trim();

            // Obtener las condiciones y valores de los ComboBox
            string minSalaryCondition = comboBoxMinCompare.SelectedItem.ToString(); // Ejemplo: '=', '>', '<'
            decimal? minSalary = string.IsNullOrEmpty(textBoxMinSalary.Text) ? (decimal?)null : decimal.Parse(textBoxMinSalary.Text);

            string maxSalaryCondition = comboBoxMaxCompare.SelectedItem.ToString(); // Ejemplo: '=', '>', '<'
            decimal? maxSalary = string.IsNullOrEmpty(textBoxMaxSalary.Text) ? (decimal?)null : decimal.Parse(textBoxMaxSalary.Text);

            // Si no se especifica ningún filtro, cargar todos los trabajos
            if (string.IsNullOrEmpty(titleFilter) && !minSalary.HasValue && !maxSalary.HasValue)
            {
                CargarTrabajos(); // Cargar todos los trabajos sin filtros
            }
            else
            {
                // Cargar trabajos con los filtros aplicados
                CargarTrabajos(titleFilter, minSalaryCondition, minSalary, maxSalaryCondition, maxSalary);
            }
        }

        private void textBoxMinSalary_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxMaxSalary_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxMaxCompare_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMinCompare_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBorrarCampos_Click(object sender, EventArgs e)
        {
            textBoxTitle.Clear();
            textBoxMinSalary.Clear();
            textBoxMaxSalary.Clear();
            comboBoxMinCompare.SelectedIndex = 0; // Restablecer al valor predeterminado
            comboBoxMaxCompare.SelectedIndex = 0; // Restablecer al valor predeterminado
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Asegurarse de que todas las filas estén confirmadas antes de realizar cambios
                dataGridViewJobs.EndEdit();

                // Primero eliminamos las filas vacías (marcadas en amarillo)
                for (int i = dataGridViewJobs.Rows.Count - 1; i >= 0; i--)  // Recorremos las filas de abajo hacia arriba
                {
                    DataGridViewRow row = dataGridViewJobs.Rows[i];

                    // Ignorar la nueva fila sin confirmar
                    if (row.IsNewRow) continue;

                    var jobTitleCell = row.Cells["job_title"].Value;
                    var minSalaryCell = row.Cells["min_salary"].Value;
                    var maxSalaryCell = row.Cells["max_salary"].Value;

                    if (jobTitleCell == null || minSalaryCell == null || maxSalaryCell == null ||
                        string.IsNullOrWhiteSpace(jobTitleCell.ToString()) ||
                        string.IsNullOrWhiteSpace(minSalaryCell.ToString()) ||
                        string.IsNullOrWhiteSpace(maxSalaryCell.ToString()))
                    {
                        // Si la fila está vacía, eliminarla
                        int jobId = Convert.ToInt32(row.Cells["job_id"].Value);
                        if (jobId != 0) // Si es un trabajo existente en la base de datos
                        {
                            // Eliminar de la base de datos
                            DeleteJob(db.ReturnConecction(), jobId);
                        }
                        // Eliminar la fila del DataGridView
                        dataGridViewJobs.Rows.Remove(row);
                    }
                }

                // Guardar los datos
                foreach (DataGridViewRow row in dataGridViewJobs.Rows)
                {
                    if (row.IsNewRow) continue; // Ignorar la fila nueva

                    int jobId = row.Cells["job_id"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["job_id"].Value) : 0;
                    string jobTitle = row.Cells["job_title"].Value?.ToString() ?? string.Empty;
                    decimal minSalary = row.Cells["min_salary"].Value != DBNull.Value ? Convert.ToDecimal(row.Cells["min_salary"].Value) : 0;
                    decimal maxSalary = row.Cells["max_salary"].Value != DBNull.Value ? Convert.ToDecimal(row.Cells["max_salary"].Value) : 0;

                    if (jobId == 0)  // Si el jobId es 0, significa que es un nuevo trabajo
                    {
                        InsertNewJob(db.ReturnConecction(), jobTitle, minSalary, maxSalary);
                    }
                    else
                    {
                        UpdateJob(db.ReturnConecction(), jobId, jobTitle, minSalary, maxSalary);
                    }
                }

                MessageBox.Show("Cambios guardados exitosamente en la base de datos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error guardando los datos: {ex.Message}");
            }
        }

        private void InsertNewJob(SqlConnection connection, string jobTitle, decimal minSalary, decimal maxSalary)
        {
            string query = "INSERT INTO Jobs (job_title, min_salary, max_salary) VALUES (@job_title, @min_salary, @max_salary)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@job_title", jobTitle);
                command.Parameters.AddWithValue("@min_salary", minSalary);
                command.Parameters.AddWithValue("@max_salary", maxSalary);
                command.ExecuteNonQuery(); // Ejecuta la inserción
            }
        }

        private void UpdateJob(SqlConnection connection, int jobId, string jobTitle, decimal minSalary, decimal maxSalary)
        {
            string query = "UPDATE Jobs SET job_title = @job_title, min_salary = @min_salary, max_salary = @max_salary WHERE job_id = @job_id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@job_id", jobId);
                command.Parameters.AddWithValue("@job_title", jobTitle);
                command.Parameters.AddWithValue("@min_salary", minSalary);
                command.Parameters.AddWithValue("@max_salary", maxSalary);
                command.ExecuteNonQuery(); // Ejecuta la actualización
            }
        }

        private void DeleteJob(SqlConnection connection, int jobId)
        {
            string query = "DELETE FROM Jobs WHERE job_id = @job_id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@job_id", jobId);
                command.ExecuteNonQuery(); // Ejecuta el DELETE
            }
        }
        private void ListaTrabajos_Load(object sender, EventArgs e)
        {

        }

        private void labelLista_Click(object sender, EventArgs e)
        {

        }
    }
}
