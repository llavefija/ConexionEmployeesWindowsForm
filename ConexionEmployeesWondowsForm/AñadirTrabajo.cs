using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConexionEmployeesWondowsForm
{
    public partial class AñadirTrabajo : Form
    {

        private DataBase db; // Instancia de la clase DataBase

        internal AñadirTrabajo(DataBase Db)
        {
            InitializeComponent();
            this.db = Db;
            db.ConnectDB();
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        private void textBoxMinSalary_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        private void textBoxMaxSalary_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        private void ValidateFields()
        {
            bool isValid = true;

            // Validar JobTitle no vacío
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text))
            {
                isValid = false;
            }

            // Validar MinSalary y MaxSalary
            if (!decimal.TryParse(textBoxMinSalary.Text, out decimal minSalary))
            {
                isValid = false;
            }

            if (!decimal.TryParse(textBoxMaxSalary.Text, out decimal maxSalary))
            {
                isValid = false;
            }

            // Asegurarse de que MinSalary sea menor o igual a MaxSalary
            if (minSalary > maxSalary)
            {
                isValid = false;
            }

            // Habilitar o deshabilitar el botón de guardar
            buttonGuardar.Enabled = isValid;
        }

        private void buttonBorrarCampos_Click(object sender, EventArgs e)
        {
            textBoxTitle.Clear();
            textBoxMinSalary.Clear();
            textBoxMaxSalary.Clear();
            buttonGuardar.Enabled = false; // Deshabilitar el botón al borrar campos

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            // Validar los datos de entrada
            if (decimal.TryParse(textBoxMinSalary.Text, out decimal minSalary) &&
                decimal.TryParse(textBoxMaxSalary.Text, out decimal maxSalary))
            {
                string jobTitle = textBoxTitle.Text;

                // Llama a un método de la clase DataBase para insertar el trabajo
                if (db.InsertJob(jobTitle, minSalary, maxSalary)) // Sin ID
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
    }
}
