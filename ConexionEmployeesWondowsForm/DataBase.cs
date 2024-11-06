using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionEmployeesWondowsForm
{
    internal class DataBase
    {
        // Objeto de conexión a la base de datos
        private SqlConnection conexion;

        public bool IsConnected => conexion != null && conexion.State == System.Data.ConnectionState.Open;

        public SqlConnection ReturnConecction()
        {
            return conexion;
        }
        // Método para conectar a la base de datos
        public bool ConnectDB()
        {
            try
            {
                if (!IsConnected)
                {
                    // Inicializa la conexión con la cadena de conexión especificada
                    conexion = new SqlConnection(Constants.connectionString);
                    conexion.Open();

                    return IsConnected;
                }
                return IsConnected;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}");
                return false;
            }
        }

        // Método para desconectar de la base de datos
        public bool DisconnectDB()
        {
            try
            {
                if (IsConnected)
                {
                    conexion.Close();
                }
                return !IsConnected;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al desconectar de la base de datos: {ex.Message}");
                return false;
            }
        }

        // Implementación de IDisposable para liberar recursos
        public void Dispose()
        {
            if (conexion != null)
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
                conexion.Dispose();
                conexion = null;
            }
        }

    }
}
