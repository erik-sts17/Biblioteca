using Desktop_Biblioteca.DAO.Emprestimo;
using Desktop_Biblioteca.Entidades.Livro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Desktop_Biblioteca.DAO.Livro
{
    public class LivroDao : BaseDAO
    {
        public int Inserir(Entidades.Livro.Livro livro, List<int> autoresIds)
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

        public void Atualizar(Entidades.Livro.Livro livro, List<int> autoresIds)
        {
            string query = "UPDATE Livro SET " +
                               "TITULO = @Titulo, " +
                               "CATEGORIAID = @CategoriaId, " +
                               "GENEROID = @GeneroId, " +
                               "PAGINAS = @Paginas, " +
                               "IMAGEM = @Imagem, " +
                               "QUANTIDADEESTOQUE = @QuantidadeEstoque, " +
                               "ATIVO = @Ativo " +
                               "WHERE Id = @LivroId;";

            var imagemParam = new SqlParameter("@Imagem", SqlDbType.VarBinary);
            if (livro.Imagem != null)
                imagemParam.Value = livro.Imagem;

            else
                imagemParam.Value = DBNull.Value;

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@LivroId", livro.Id),
                new SqlParameter("@Titulo", livro.Titulo),
                new SqlParameter("@CategoriaId", livro.CategoriaId),
                new SqlParameter("@GeneroId", livro.GeneroId),
                new SqlParameter("@Paginas", livro.Paginas),
                imagemParam,
                new SqlParameter("@QuantidadeEstoque", livro.QuantidadeEstoque),
                new SqlParameter("@Ativo", 1)
            };
            Execute(query, parameters);

            var cmdDeleteAutor = "DELETE FROM AutoresLivros WHERE LivroId = @LivroId";
            foreach (var autorId in autoresIds)
            {
                SqlParameter[] deleteAutor = new SqlParameter[]
                {
                    new SqlParameter("@AutorId", autorId),
                    new SqlParameter("@LivroId", livro.Id)
                };
                Execute(cmdDeleteAutor, deleteAutor);
            }


            string cmdInsertAutor = "INSERT INTO AUTORESLIVROS(AUTORID, LIVROID) " +
                                   "VALUES (@AutorId, @LivroId)";
            foreach (var autorId in autoresIds)
            {
                SqlParameter[] parametersAutor = new SqlParameter[]
                {
                    new SqlParameter("@AutorId", autorId),
                    new SqlParameter("@LivroId", livro.Id)
                };
                Execute(cmdInsertAutor, parametersAutor);
            }
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

        public List<Entidades.Livro.Livro> BuscarTodos(bool estoque = false, Filtro filtro = null)
        {
            string query = "SELECT l.*, c.Descricao AS DescricaoCategoria, g.Descricao AS DescricaoGenero FROM Livro l " +
                            "INNER JOIN Categoria c on l.CategoriaId = c.Id " +
                            "INNER JOIN Genero g on l.GeneroId = g.Id " +
                            "WHERE l.ATIVO = 1 ";

            if (estoque)
            {
                query += "AND QuantidadeEstoque > 0 ";
            }

            if (filtro != null)
            {
                if (!string.IsNullOrEmpty(filtro.Titulo))
                    query += $"AND l.Titulo LIKE '%{filtro.Titulo}%' ";

                if (filtro.CategoriaId != 0)
                    query += $"AND l.CategoriaId = {filtro.CategoriaId} ";

                if (filtro.GeneroId != 0)
                    query += $"AND l.GeneroId = {filtro.GeneroId} ";
            }

            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, con);
            con.Open();
            var reader = sqlCommand.ExecuteReader();
            List<Entidades.Livro.Livro> livros = new List<Entidades.Livro.Livro>();
            while (reader.Read())
            {
                Entidades.Livro.Livro livro = new Entidades.Livro.Livro()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Titulo = reader.GetString(reader.GetOrdinal("Titulo")),
                    Paginas = reader.GetInt32(reader.GetOrdinal("Paginas")),
                    QuantidadeEstoque = reader.GetInt32(reader.GetOrdinal("QuantidadeEstoque")),
                    Imagem = reader.IsDBNull(reader.GetOrdinal("Imagem")) ? null : (byte[])reader["Imagem"],
                    Categoria = new Categoria()
                    {
                        Descricao = reader.GetString(reader.GetOrdinal("DescricaoCategoria")),
                    },
                    Genero = new Genero()
                    {
                        Descricao = reader.GetString(reader.GetOrdinal("DescricaoGenero")),
                    },
                };
                livros.Add(livro);
            }
            con.Close();
            return livros;
        }

        public Entidades.Livro.Livro BuscarPorId(int livroId)
        {
            string query = "SELECT l.*, c.Id AS CategoriaId, g.Id AS GeneroId FROM Livro l " +
                            "INNER JOIN Categoria c on l.CategoriaId = c.Id " +
                            "INNER JOIN Genero g on l.GeneroId = g.Id " +
                            "WHERE l.Id = @LivroId";

            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, con);
            sqlCommand.Parameters.Add(new SqlParameter("@LivroId", livroId));
            con.Open();
            var reader = sqlCommand.ExecuteReader();
            Entidades.Livro.Livro livro = null;
            while (reader.Read())
            {
                livro = new Entidades.Livro.Livro()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Titulo = reader.GetString(reader.GetOrdinal("Titulo")),
                    Paginas = reader.GetInt32(reader.GetOrdinal("Paginas")),
                    QuantidadeEstoque = reader.GetInt32(reader.GetOrdinal("QuantidadeEstoque")),
                    Imagem = reader.IsDBNull(reader.GetOrdinal("Imagem")) ? null : (byte[])reader["Imagem"],
                    Categoria = new Categoria()
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("CategoriaId")),
                    },
                    Genero = new Genero()
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("GeneroId")),
                    },
                };
                livro.AutoresId = new AutorDao().BuscarAutoresPorLivro(livro.Id);
            }
            con.Close();
            return livro;
        }
    }
}