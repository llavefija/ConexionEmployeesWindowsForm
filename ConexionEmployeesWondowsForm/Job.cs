using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionEmployeesWondowsForm
{
    internal class Job
    {
        private DataBase db; // Instancia de la clase DataBase

        private SqlConnection conexion;

        internal Job(DataBase Db)
        {
            this.db = Db;
            db.ConnectDB();

            conexion = db.ReturnConecction();
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

        // Método para cargar los trabajos de la base de datos
        public DataTable CargarTrabajos(string jobTitle = "", string minSalaryCondition = "=", decimal? minSalary = null, string maxSalaryCondition = "=", decimal? maxSalary = null)
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

                using (SqlCommand command = new SqlCommand(query, conexion))
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

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los trabajos: {ex.Message}");
                return null;
            }
        }

        public bool UpdateJob(int jobId, string jobTitle, decimal minSalary, decimal maxSalary)
        {
            try
            {
                string query = "UPDATE Jobs SET job_title = @job_title, min_salary = @min_salary, max_salary = @max_salary WHERE job_id = @job_id";
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@job_id", jobId);
                    command.Parameters.AddWithValue("@job_title", jobTitle);
                    command.Parameters.AddWithValue("@min_salary", minSalary);
                    command.Parameters.AddWithValue("@max_salary", maxSalary);
                    command.ExecuteNonQuery(); // Ejecuta la actualización

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; // Devuelve true si se insertó al menos una fila
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los trabajos: {ex.Message}");
                return false;
            }
        }

        public bool DeleteJob(int jobId)
        {
            try
            {
                string query = "DELETE FROM Jobs WHERE job_id = @job_id";
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@job_id", jobId);
                    command.ExecuteNonQuery(); // Ejecuta el DELETE

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; // Devuelve true si se insertó al menos una fila
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los trabajos: {ex.Message}");
                return false;
            }
        }
    }


}
