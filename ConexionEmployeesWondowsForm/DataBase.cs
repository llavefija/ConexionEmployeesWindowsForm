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

        public bool InsertJob(string jobTitle, decimal minSalary, decimal maxSalary)
        {
            try
            {
                string query = "INSERT INTO Jobs (job_title, min_salary, max_salary) VALUES (@job_title, @min_salary, @max_salary)";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@job_title", jobTitle);
                    command.Parameters.AddWithValue("@min_salary", minSalary);
                    command.Parameters.AddWithValue("@max_salary", maxSalary);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; // Devuelve true si se insertó al menos una fila
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar el trabajo: {ex.Message}");
                return false;
            }
        }



    }
}
