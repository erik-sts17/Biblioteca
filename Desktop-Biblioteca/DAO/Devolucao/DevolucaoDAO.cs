using Desktop_Biblioteca.DAO.Emprestimo;
using Desktop_Biblioteca.DAO.Livro;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Desktop_Biblioteca.DAO.Devolucao
{
    public class DevolucaoDAO : BaseDAO
    {
        public void Devolver(int emprestimoId, List<int> livrosIds)
        {
            var queryDevolucao = "INSERT INTO DEVOLUCAO (EmprestimoId, DataDevolucao) VALUES (@EmprestimoId, @DataDevolucao)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@DataDevolucao", DateTime.Now),
                new SqlParameter("@EmprestimoId", emprestimoId),
            };
            Execute(queryDevolucao, parameters);

            var query = " UPDATE Emprestimo SET Ativo = 0 WHERE Id = @EmprestimoId";
            var parameter = new SqlParameter("@EmprestimoId", emprestimoId);
            Execute(query, new SqlParameter[] { parameter });

            LivroDao livroDao = new LivroDao();
            foreach (var livroId in livrosIds)
            {
                livroDao.AtualizarEstoque(livroId, TipoOperacao.DEVOLUCAO, 1);
            }
            
        }
    }
}
