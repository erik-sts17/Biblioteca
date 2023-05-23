using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Desktop_Biblioteca.DAO
{
    public class BaseDAO
    {
        private string _connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        public void Execute(string sqlQuery, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);
                    if (parameters != null)
                    {
                        sqlCommand.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    sqlCommand.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        protected object ExecuteScalar(string sqlQuery, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);
                    if (parameters != null)
                    {
                        sqlCommand.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    return sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
