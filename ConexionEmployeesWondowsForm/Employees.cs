using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionEmployeesWondowsForm
{
    internal class Employees
    {
        private DataBase db; // Instancia de la clase DataBase

        private SqlConnection conexion;

        internal Employees(DataBase Db)
        {
            this.db = Db;
            db.ConnectDB();

            conexion = db.ReturnConecction();
        }

        public bool InsertEmployee(string nombre, string apellido1, string apellido2, string email, string telf, DateTime fechaNacimiento, int idEmpleo, int salario, int idManager, string departamento)
        {
            try
            {
                // Modificar la consulta SQL con los nuevos campos
                string query = "INSERT INTO Employees (nombre, apellido1, apellido2, email, telefono, fecha_nacimiento, id_empleo, salario, id_manager, departamento) " +
                               "VALUES (@nombre, @apellido1, @apellido2, @email, @telefono, @fecha_nacimiento, @id_empleo, @salario, @id_manager, @departamento)";

                // Utilizar el using para asegurar que el comando y la conexión se liberen correctamente
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    // Añadir los parámetros al comando
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido1", apellido1);
                    command.Parameters.AddWithValue("@apellido2", apellido2);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@telefono", telf);
                    command.Parameters.AddWithValue("@fecha_nacimiento", fechaNacimiento);
                    command.Parameters.AddWithValue("@id_empleo", idEmpleo);
                    command.Parameters.AddWithValue("@salario", salario);
                    command.Parameters.AddWithValue("@id_manager", idManager);
                    command.Parameters.AddWithValue("@departamento", departamento);

                    // Ejecutar la consulta
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; // Devuelve true si se insertó al menos una fila
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar el empleado: {ex.Message}");
                return false;
            }
        }

    }
}
