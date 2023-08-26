using Desktop_Biblioteca.DAO.Emprestimo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Desktop_Biblioteca.DAO.Livro
{
    public class LivroDao : BaseDAO
    {
        public int Insert(Entidades.Livro.Livro livro, List<int> autoresIds)
        {
            string cmdInsert = "INSERT INTO LIVRO (TITULO, CATEGORIAID, GENEROID, PAGINAS, IMAGEM, QUANTIDADEESTOQUE, ATIVO) " +
                                "VALUES (@Titulo, @CategoriaId, @GeneroId, @Paginas, @Imagem, @QuantidadeEstoque, @Ativo);" +
                                "SELECT CAST(scope_identity() AS int)";

            var imagemParam = new SqlParameter("@Imagem", SqlDbType.VarBinary);
            if (livro.Imagem != null)
                imagemParam.Value = livro.Imagem;

            else
                imagemParam.Value = DBNull.Value;

            SqlParameter[] parameters = new SqlParameter[]
            {

                new SqlParameter("@Titulo", livro.Titulo),
                new SqlParameter("@CategoriaId", livro.CategoriaId),
                new SqlParameter("@GeneroId", livro.GeneroId),
                new SqlParameter("@Paginas", livro.Paginas),
                imagemParam,
                new SqlParameter("@QuantidadeEstoque", livro.QuantidadeEstoque),
                new SqlParameter("@Ativo", 1)
            };

            int livroId = (int)ExecuteScalar(cmdInsert, parameters);

            string cmdInsertAutor = "INSERT INTO AUTORESLIVROS(AUTORID, LIVROID) " +
                                    "VALUES (@AutorId, @LivroId)";


            foreach (int autorId in autoresIds)
            {
                SqlParameter[] parametersAutor = new SqlParameter[]
                {
                    new SqlParameter("@AutorId", autorId),
                    new SqlParameter("@LivroId", livroId)
                };

                Execute(cmdInsertAutor, parametersAutor);
            }
            return livroId;
        }

        public void AtualizarEstoque(int livroId, TipoOperacao tipoOperacao, int quantidade)
        {
            string operacao = "";
            if (tipoOperacao == TipoOperacao.EMPRESTIMO)
                operacao = "-";
            
            else
                operacao = "+";

            string comandoAtualizar = $" UPDATE LIVRO SET QuantidadeEstoque = QuantidadeEstoque {operacao} @Quantidade WHERE Id = @LivroId";
            SqlParameter[] parametros =
            {
               
                new SqlParameter("@Quantidade", quantidade),
                new SqlParameter("@LivroId", livroId)
            };
            Execute(comandoAtualizar, parametros);
        }

        public List<Entidades.Livro.Livro> BuscarTodos()
        {
            string query = "SELECT * FROM Livro WHERE ATIVO = 1 AND QuantidadeEstoque > 0";
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, con);
            con.Open();
            var reader = sqlCommand.ExecuteReader();
            List<Entidades.Livro.Livro> livros = new List<Entidades.Livro.Livro>();
            while (reader.Read())
            {
                Entidades.Livro.Livro livro = new Entidades.Livro.Livro()
                {
                    Id = (int)reader["Id"],
                    Titulo = (string)reader["Titulo"],
                    Paginas = (int)reader["Paginas"]
                };
                livros.Add(livro);
            }
            con.Close();
            return livros;
        }
    }
}