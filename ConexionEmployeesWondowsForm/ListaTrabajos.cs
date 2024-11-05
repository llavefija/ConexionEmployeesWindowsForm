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

        internal ListaTrabajos(DataBase Db)
        {
            InitializeComponent();
            this.db = Db;
            db.ConnectDB();
            // Establecer la opción predeterminada
            comboBoxMinCompare.SelectedIndex = 0; // Por defecto "=", que es el primer ítem
            comboBoxMaxCompare.SelectedIndex = 0; // Por defecto "=", que es el primer ítem
            CargarTrabajos();
        }

        private void dataGridViewJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarTrabajos(string jobTitle = "", string minSalaryCondition = "=", decimal? minSalary = null, string maxSalaryCondition = "=", decimal? maxSalary = null)
        {
            try
            {
                // Crear la consulta SQL
                string query = "SELECT job_title, min_salary, max_salary FROM Jobs WHERE 1=1";

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
    }
}
