using Desktop_Biblioteca.Entidades.Livro;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace Desktop_Biblioteca.DAO.Livro
{
    public class AutorDao : BaseDAO
    {
        public void Insert(Autor autor)
        {
            string cmdInsert = "INSERT INTO Autor (NOME, ATIVO) VALUES (@Nome, @Ativo)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Nome", autor.Nome),
                new SqlParameter("@Ativo", 1)
            };
            Execute(cmdInsert, parameters);
        }

        public void Atualizar(Autor autor)
        {
            string cmdUpdate = "UPDATE Autor SET NOME = @Nome, ATIVO = @Ativo WHERE ID = @Id";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Nome", autor.Nome),
                new SqlParameter("@Ativo", 1),
                new SqlParameter("@Id", autor.Id)
            };
            Execute(cmdUpdate, parameters);
        }

        public List<Autor> Buscar()
        {
            string cmdInsert = "SELECT NOME, ID FROM biblioteca.dbo.Autor WHERE ATIVO = 1";
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand sqlCommand = new SqlCommand(cmdInsert, con);
            con.Open();
            var reader = sqlCommand.ExecuteReader();
            List<Autor> autores = new List<Autor>();
            while (reader.Read())
            {
                Autor autor = new Autor();
                autor.Nome = reader.GetString(reader.GetOrdinal("Nome"));
                autor.Id = reader.GetInt32(reader.GetOrdinal("ID"));
                autores.Add(autor);
            }
            con.Close();
            return autores;
        }

        public List<int> BuscarAutoresPorLivro(int livroId)
        {
            string cmdInsert = "SELECT AutorId AS ID FROM AUTORESLIVROS where LivroId = @LivroId";
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand sqlCommand = new SqlCommand(cmdInsert, con);
            sqlCommand.Parameters.Add(new SqlParameter("@LivroId", livroId));
            con.Open();
            var reader = sqlCommand.ExecuteReader();
            List<int> autoresIds = new List<int>();
            while (reader.Read())
            {
                autoresIds.Add(reader.GetInt32(reader.GetOrdinal("ID")));
            }
            con.Close();
            return autoresIds;
        }
    }
}
