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

        private DataBase db; // Instancia de la clase DataBase

        public FormConexión()
        {
            InitializeComponent();
            db = new DataBase();

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
            if (db.ConnectDB())
            {
                MessageBox.Show("Conexión exitosa a la base de datos.");
            }
            else
            {
                MessageBox.Show("Error al conectar a la base de datos.");
            }
            ActualizarEstadoConexion();
        }

        // Método para liberar recursos cuando se cierra el formulario
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            db.Dispose();
            base.OnFormClosing(e);
        }
    }
}
