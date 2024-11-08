using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionEmployeesWondowsForm
{
    public partial class AñadirTrabajo : Form
    {

        private ToolTip toolTip;

        private DataBase db; // Instancia de la clase DataBase
        private Job job; // Instancia de la clase DataBase


        internal AñadirTrabajo(DataBase Db)
        {
            InitializeComponent();

            this.db = Db; // Inicializa db
            this.job = new Job(db); // Inicializa job
            db.ConnectDB(); // Establece conexion con la bd si no se ha conectado anteriormente

            // Inicializar ToolTip
            toolTip = new ToolTip();

            // Configurar ToolTip para un botón específico
            toolTip.SetToolTip(buttonBorrarCampos, "Vacia todos los campos.");
            toolTip.SetToolTip(buttonGuardar, "Guarda el trabajo nuevo a la BD.");
            toolTip.SetToolTip(buttonMenu, "Regresa al menú principal.");

            // Establece un minSalary y un maxSalary a 0
            textBoxMinSalary.Text = "0";
            textBoxMaxSalary.Text = "0";

            

        }

        // Valida que el titulo sea correcto
        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        // Valida que el minSalary sea correcto
        private void textBoxMinSalary_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        // Valida que el maxSalary sea correcto
        private void textBoxMaxSalary_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        // Metodo para validar parametros
        private void ValidateFields()
        {
            bool isValid = true;

            // Validar JobTitle no vacío
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text))
            {
                isValid = false;
            }
            else
            {
                textBoxTitle.ForeColor = Color.Green; // Establece un color verde si el texto es correcto

            }

            if (!decimal.TryParse(textBoxMinSalary.Text, out decimal minSalary))
            {
                isValid = false;
                textBoxMinSalary.ForeColor = Color.Red; // Establece un color rojo si el formato o contenido no es correcto
            }
            else
            {
                textBoxMinSalary.ForeColor = Color.Green; // Establece un color verde si el formato o contenido si es correcto

            }

            if (!decimal.TryParse(textBoxMaxSalary.Text, out decimal maxSalary))
            {
                isValid = false;
                textBoxMaxSalary.ForeColor = Color.Red; // Establece un color rojo si el formato o contenido no es correcto
            }
            else
            {
                textBoxMaxSalary.ForeColor = Color.Green; // Establece un color verde si el formato o contenido si es correcto

            }

            // Asegurarse de que MinSalary sea menor o igual a MaxSalary
            if (minSalary > maxSalary)
            {
                isValid = false;
                textBoxMinSalary.ForeColor = Color.Red;
                textBoxMaxSalary.ForeColor = Color.Red;
            }

            // Habilitar o deshabilitar el botón de guardar
            buttonGuardar.Enabled = isValid;
        }

        // Evento del boton borrar campos
        private void buttonBorrarCampos_Click(object sender, EventArgs e)
        {
            textBoxTitle.Clear();
            textBoxMinSalary.Clear();
            textBoxMaxSalary.Clear();
            buttonGuardar.Enabled = false; // Deshabilitar el botón al borrar campos

        }

        // Evento del boton guardar campos
        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            // Validar los datos de entrada
            if (decimal.TryParse(textBoxMinSalary.Text, out decimal minSalary) &&
                decimal.TryParse(textBoxMaxSalary.Text, out decimal maxSalary))
            {
                string jobTitle = textBoxTitle.Text;

                // Llama a un método de la clase DataBase para insertar el trabajo
                if (job.InsertJob(jobTitle, minSalary, maxSalary)) // Sin ID
                {
                    MessageBox.Show("Trabajo insertado con éxito.");
                    this.Close(); // Cierra el formulario después de guardar
                }
                else
                {
                    MessageBox.Show("Error al insertar el trabajo.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduce valores válidos.");
            }

        }

        // Evento del boton menu
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelMaxSalary_Click(object sender, EventArgs e)
        {
        }

        private void labelMinSalary_Click(object sender, EventArgs e)
        {
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
        }

        private void AñadirTrabajo_Load(object sender, EventArgs e)
        {
        }
    }
}
