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


    public partial class FormConexión : Form
    {
        private ToolTip toolTip;

        private DataBase db; // Instancia de la clase DataBase

        

        public FormConexión()
        {
            InitializeComponent();
            db = new DataBase();

            // Inicializar ToolTip
            toolTip = new ToolTip();

            // Configurar ToolTip para un botón específico
            toolTip.SetToolTip(buttonConnect, "Establece conexión con la BD Employees.");
            toolTip.SetToolTip(buttonDisconnect, "Desconecta la conexión con la BD Employees.");
            toolTip.SetToolTip(buttonSalir, "Salir de la aplicación.");
            toolTip.SetToolTip(buttonLista, "Abre el menú para listar todos los trabajos de la BD.");
            toolTip.SetToolTip(buttonAddJob, "Abre el menú para añadir un trabajo a la BD.");


        }

        private void FormConexión_Load(object sender, EventArgs e)
        {
            ActualizarEstadoConexion();
        }

        // Método para actualizar el estado del Label
        private void ActualizarEstadoConexion()
        {
            if (db.IsConnected)
            {
                labelEstadoConexion.Text = "Conectado";
                labelEstadoConexion.ForeColor = Color.Green;
                buttonConnect.Enabled = false;
                buttonDisconnect.Enabled = true;
            }
            else
            {
                labelEstadoConexion.Text = "Desconectado";
                labelEstadoConexion.ForeColor = Color.Red;
                buttonConnect.Enabled = true;
                buttonDisconnect.Enabled = false;
            }
        }

        private void labelEstado(object sender, EventArgs e)
        {
          
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (db.DisconnectDB())
            {
                MessageBox.Show("Desconexión exitosa de la base de datos.");
            }
            else
            {
                MessageBox.Show("Error al desconectar de la base de datos.");
            }
            ActualizarEstadoConexion();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            db.ConnectDB();
            ActualizarEstadoConexion();
        }

        // Método para liberar recursos cuando se cierra el formulario
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            db.Dispose();
            base.OnFormClosing(e);
        }

        private void buttonAddJob_Click(object sender, EventArgs e)
        {
            AñadirTrabajo formAgregarTrabajo = new AñadirTrabajo(db);
            formAgregarTrabajo.ShowDialog(); // Muestra el formulario como un diálogo modal
            ActualizarEstadoConexion();
        }

        private void buttonLista_Click(object sender, EventArgs e)
        {
            ListaTrabajos formListaTrabajos = new ListaTrabajos(db);
            formListaTrabajos.ShowDialog(); // Muestra el formulario como un diálogo modal
            ActualizarEstadoConexion();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra toda la aplicación
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            AñadirEmpledo formAñadirEmpleado = new AñadirEmpledo(db);
            formAñadirEmpleado.ShowDialog(); // Muestra el formulario como un diálogo modal
            ActualizarEstadoConexion();
        }
    }
}
