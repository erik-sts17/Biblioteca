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
            string cmdInsert = "INSERT INTO LIVRO (TITULO, CATEGORIAID, GENEROID, PAGINAS, IMAGEM, ATIVO) " +
                                "VALUES (@Titulo, @CategoriaId, @GeneroId, @Paginas, @Imagem, @Ativo);" +
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
    }
}