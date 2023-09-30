using Desktop_Biblioteca.Entidades.Livro;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Desktop_Biblioteca.DAO.Livro
{
    public class GeneroDao : BaseDAO
    {
        public void Inserir(Genero genero)
        {
            string cmdInsert = "INSERT INTO Genero (DESCRICAO, ATIVO) VALUES (@Descricao, @Ativo)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Descricao", genero.Descricao),
                new SqlParameter("@Ativo", 1)
            };
            Execute(cmdInsert, parameters);
        }

        public void Atualizar(Genero genero)
        {
            string cmdUpdate = "UPDATE Genero SET Descricao = @Descricao, ATIVO = @Ativo WHERE ID = @Id";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Descricao", genero.Descricao),
                new SqlParameter("@Ativo", 1),
                new SqlParameter("@Id", genero.Id)
            };
            Execute(cmdUpdate, parameters);
        }

        public List<Genero> Buscar()
        {
            string cmdInsert = "SELECT DESCRICAO, ID FROM biblioteca.dbo.GENERO WHERE ATIVO = 1";
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand sqlCommand = new SqlCommand(cmdInsert, con);
            con.Open();
            var reader = sqlCommand.ExecuteReader();
            List<Genero> generos = new List<Genero>();
            while (reader.Read())
            {
                Genero genero = new Genero();
                genero.Descricao = reader.GetString(reader.GetOrdinal("Descricao"));
                genero.Id = reader.GetInt32(reader.GetOrdinal("ID"));
                generos.Add(genero);
            }
            con.Close();
            return generos;
        }
    }
}
