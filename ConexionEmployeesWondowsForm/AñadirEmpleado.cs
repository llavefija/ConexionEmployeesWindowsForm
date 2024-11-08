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
    public partial class AñadirEmpledo : Form
    {

        private ToolTip toolTip;

        private DataBase db; // Instancia de la clase DataBase
        private Job job; // Instancia de la clase DataBase


        internal AñadirEmpledo(DataBase Db)
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

            // Establece el salaio a 0
            textBoxSalario.Text = "0";
            

        }

        // Valida que el titulo sea correcto
        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
        }

        // Valida que el minSalary sea correcto
        private void textBoxMinSalary_TextChanged(object sender, EventArgs e)
        {
        }

        // Valida que el maxSalary sea correcto
        private void textBoxApellido2_TextChanged(object sender, EventArgs e)
        {
        }


        // Evento del boton borrar campos
        private void buttonBorrarCampos_Click(object sender, EventArgs e)
        {
            textBoxNombre.Clear();
            textBoxApellido1.Clear();
            textBoxApellido2.Clear();
            textBoxEmail.Clear();
            textBoxTelf.Clear();
            textBoxSalario.Clear();
            buttonGuardar.Enabled = false; // Deshabilitar el botón al borrar campos

        }

        // Evento del boton guardar campos
        private void buttonGuardar_Click(object sender, EventArgs e)
        {

        }

        // Evento del boton menu
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
