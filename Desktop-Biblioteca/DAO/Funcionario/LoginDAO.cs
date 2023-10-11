using System.Data.SqlClient;

namespace Desktop_Biblioteca.DAO.Funcionario
{
    internal class LoginDAO : BaseDAO
    {
        public void Inserir(Entidades.Login login)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@Email", login.Email),
                new SqlParameter("@Senha", login.Senha),
            };

            string query = "INSERT INTO Login (EMAIL, SENHA) " +
                           "VALUES (@Email, @Senha)";

            Execute(query, parameters);
        }

        public string ObterSenhaCliente(string email)
        {
            string query = "SELECT L.Senha FROM Login L INNER JOIN Cliente C ON L.Email = C.Email WHERE L.Email = @Email";
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, con);
            sqlCommand.Parameters.Add(new SqlParameter("@Email", email));
            con.Open();
            var reader = sqlCommand.ExecuteReader();
            string senha = "";
            while (reader.Read())
            {
                senha = (string)reader["Senha"];
            }
            con.Close();
            return senha;
        }

        public bool ValidaLogin(Entidades.Login login)
        {
            SqlParameter[] parameters =
               {
                    new SqlParameter("@Email", login.Email),
                    new SqlParameter("@Senha", login.Senha),
                };
            string query = "SELECT COUNT(*) FROM Login L INNER JOIN Funcionario F ON L.Email = F.Email WHERE L.Email = @Email AND L.Senha = @Senha AND F.Ativo = 1";
            var result = (int)ExecuteScalar(query, parameters);
            return result > 0;
        }

        public void AlterarSenha(Entidades.Login login)
        {
            SqlParameter[] parameters =
               {
                    new SqlParameter("@Email", login.Email),
                    new SqlParameter("@NovaSenha", login.Senha),
                };
            string query = "UPDATE Login SET Senha = @NovaSenha FROM Login L INNER JOIN Funcionario F ON L.Email = F.Email WHERE L.Email = @Email";
            Execute(query, parameters);
        }
    }
}
