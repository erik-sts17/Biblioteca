using Desktop_Biblioteca.Entidades;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Desktop_Biblioteca.DAO.Funcionario
{
    internal class LoginDAO : BaseDAO
    {
        public void Insert(Entidades.Login login)
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

        public bool ValidaLogin(Entidades.Login login)
        {
            SqlParameter[] parameters =
               {
                    new SqlParameter("@Email", login.Email),
                    new SqlParameter("@Senha", login.Senha),
                };
            string query = "SELECT COUNT(*) FROM login WHERE email = @Email AND senha = @Senha";
            var result = (int)ExecuteScalar(query, parameters);
            return result > 0;
        }
    }
}
