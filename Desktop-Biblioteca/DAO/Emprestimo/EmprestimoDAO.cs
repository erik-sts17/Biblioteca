using Desktop_Biblioteca.DAO.Livro;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Desktop_Biblioteca.DAO.Emprestimo
{
    public class EmprestimoDAO : BaseDAO
    {
        public int Inserir(Entidades.Emprestimo emprestimo, List<int> livrosIds)
        {
            var query = " INSERT INTO Emprestimo(ClienteId, DataEmprestimo, DataMaximaDevolucao, FuncionarioId ,Ativo)" +
                        " VALUES(@ClienteId, @DataEmprestimo, @DataMaximaDevolucao, @FuncionarioId, @Ativo)" +
                        " SELECT CAST(scope_identity() AS int)";

            SqlParameter[] parameters = new SqlParameter[]
            {

                new SqlParameter("@ClienteId", emprestimo.ClienteId),
                new SqlParameter("@FuncionarioId", emprestimo.FuncionarioId),
                new SqlParameter("@DataEmprestimo", emprestimo.DataEmprestimo),
                new SqlParameter("@DataMaximaDevolucao", emprestimo.DataMaximaDevolucao),
                new SqlParameter("@Ativo", true),
            };


            int emprestimoId = (int)ExecuteScalar(query, parameters);

            string cmdInsertLivros = " INSERT INTO EmprestimoLivro(EmprestimoId, LivroId)" +
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


        public List<int> BuscarLivrosId(int idEmprestimo) 
        {
            var query = $"SELECT EMP.LivroId FROM EMPRESTIMO E INNER JOIN EmprestimoLivro EMP ON E.Id = EMP.EmprestimoId WHERE E.Id = {idEmprestimo}";
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, con);
            con.Open();
            var reader = sqlCommand.ExecuteReader();
            var livroIds = new List<int>();
            while (reader.Read())
            {
                livroIds.Add(reader.GetInt32(reader.GetOrdinal("Livroid")));
            }
            con.Close();
            return livroIds;
        }

        public List<Entidades.EmprestimoDTO> BuscarEmprestimos(Entidades.Filtro filtro = null)
        {
            var query = " SELECT E.Id, C.Nome, C.Email, E.DataEmprestimo, E.DataMaximaDevolucao, D.DataDevolucao, COUNT(L.LivroId) AS TotalLivros FROM Emprestimo E " +
                        " INNER JOIN Cliente C on E.ClienteId = C.Id " +
                        " INNER JOIN EmprestimoLivro AS L on E.Id = L.EmprestimoId " +
                        " LEFT JOIN Devolucao D on E.Id = D.EmprestimoId ";

            if (filtro != null)
            {
                if (filtro.Status == Entidades.Status.Devolvidos)
                {
                    query += $" WHERE E.Ativo = 0 ";
                }
                else if (filtro.Status == Entidades.Status.Emprestados)
                {
                    query += $" WHERE E.Ativo = 1 ";
                }
                else
                {
                    query += $" WHERE E.Ativo IN (0,1) ";

                }

                if (!string.IsNullOrEmpty(filtro.EmailCliente))
                {
                    query += $" AND C.Email = '{filtro.EmailCliente}' ";
                }
                if (filtro.Status == Entidades.Status.Atrasados)
                {
                    var queryData = $" (E.DataMaximaDevolucao < CONVERT(DATE, '{DateTime.Now.ToString("yyyy-MM-dd")}') AND D.DataDevolucao IS NULL)";
                    query += (" AND " + queryData);
                }
            }

            query += " GROUP BY E.Id, C.Nome, C.Email, E.DataEmprestimo, E.DataMaximaDevolucao, D.DataDevolucao";

            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, con);
            con.Open();
            var reader = sqlCommand.ExecuteReader();
            var emprestimos = new List<Entidades.EmprestimoDTO>();
            while (reader.Read())
            {
                var emprestimo = new Entidades.EmprestimoDTO()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    NomeCliente = reader.GetString(reader.GetOrdinal("Nome")),
                    EmailCliente = reader.GetString(reader.GetOrdinal("Email")),
                    DataEmprestimo = reader.GetDateTime(reader.GetOrdinal("DataEmprestimo")),
                    DataEsperadaDevolucao = reader.GetDateTime(reader.GetOrdinal("DataMaximaDevolucao")),
                    TotalLivros = reader.GetInt32(reader.GetOrdinal("TotalLivros")),
                };
                if (!reader.IsDBNull(reader.GetOrdinal("DataDevolucao")))
                {
                    emprestimo.DataDevolucao = reader.GetDateTime(reader.GetOrdinal("DataDevolucao"));
                }
                emprestimos.Add(emprestimo);
            }
            con.Close();
            return emprestimos;
        }
    }
}
