using Desktop_Biblioteca.DAO.Livro;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Desktop_Biblioteca.DAO.Emprestimo
{
    public class EmprestimoDAO : BaseDAO
    {
        public int Inserir(Entidades.Emprestimo emprestimo, List<int> livrosIds, int clienteId)
        {
            var query = " INSERT INTO Emprestimo(ClienteId, DataEmprestimo, DataMaximaDevolucao, Ativo)" +
                        " VALUES(@ClienteId, @DataEmprestimo, @DataMaximaDevolucao, @Ativo)" +
                        " SELECT CAST(scope_identity() AS int)";

            SqlParameter[] parameters = new SqlParameter[]
            {

                new SqlParameter("@ClienteId", clienteId),
                new SqlParameter("@DataEmprestimo", emprestimo.DataEmprestimo),
                new SqlParameter("@DataMaximaDevolucao", emprestimo.DataMaximaDevolucao),
                new SqlParameter("@Ativo", true),
            };


            int emprestimoId = (int)ExecuteScalar(query, parameters);

            string cmdInsertLivros =" INSERT INTO EmprestimoLivro(EmprestimoId, LivroId)" +
                                    " VALUES (@EmprestimoId, @LivroId)";

            var livroDao = new LivroDao();
            foreach (int livroId in livrosIds)
            {
                SqlParameter[] parametersAutor = new SqlParameter[]
                {
                    new SqlParameter("@EmprestimoId", emprestimoId),
                    new SqlParameter("@LivroId", livroId)
                };

                Execute(cmdInsertLivros, parametersAutor);
                livroDao.AtualizarEstoque(livroId, TipoOperacao.EMPRESTIMO, 1);
            }
            return emprestimoId;
        }

        public bool VerificarEmprestimoAtivo(int clienteId) 
        {
            var query = " SELECT CASE WHEN COUNT(*) > 0 THEN 1 ELSE 0 END AS TemEmprestimoAtivo " +
                        " FROM Emprestimo " +
                        " WHERE ClienteId = @ClienteId " +
                        "  AND Ativo = 1 ";

            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, con);
            sqlCommand.Parameters.Add(new SqlParameter("@ClienteId", clienteId));
            con.Open();
            var reader = sqlCommand.ExecuteReader();
            int existe = 0;
            while (reader.Read())
            {
                existe = (int)reader["TemEmprestimoAtivo"];
            }
            con.Close();
            if (existe == 0)
                return false;
            return true;
        }
    }
}
