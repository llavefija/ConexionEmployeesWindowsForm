using System;
using System.Collections.Generic;
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

        internal Job(DataBase Db)
        {
            this.db = Db;
            db.ConnectDB();
        }

        public bool InsertJob(string jobTitle, decimal minSalary, decimal maxSalary)
        {
            try
            {
                string query = "INSERT INTO Jobs (job_title, min_salary, max_salary) VALUES (@job_title, @min_salary, @max_salary)";

                using (SqlCommand command = new SqlCommand(query, db.ReturnConecction()))
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
