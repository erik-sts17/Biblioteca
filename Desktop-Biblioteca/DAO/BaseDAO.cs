using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace Desktop_Biblioteca.DAO
{
    public class BaseDAO
    {
        protected string _connectionString = ConfigurationManager.AppSettings["ConnectionString"];
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

        public object Excluir(string nomeTabela, List<int> ids)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            for (int i = 0; i < ids.Count; i++)
            {
                string parameterName = $"@Id{i}";
                SqlParameter parameter = new SqlParameter(parameterName, ids[i]);
                parameters.Add(parameter);
            }

            string query = $"UPDATE {nomeTabela} SET ATIVO = 0 WHERE ID IN ({string.Join(",", parameters.Select(p => p.ParameterName))})";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    if (parameters != null)
                    {
                        sqlCommand.Parameters.AddRange(parameters.ToArray());
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
