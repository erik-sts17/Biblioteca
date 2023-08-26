using Desktop_Biblioteca.Entidades.Livro;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Desktop_Biblioteca.DAO.Livro
{
    public class CategoriaDao : BaseDAO
    {
        public void Insert(Categoria categoria)
        {
            string cmdInsert = "INSERT INTO Categoria (DESCRICAO, ATIVO) VALUES (@Descricao, @Ativo)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Descricao", categoria.Descricao),
                new SqlParameter("@Ativo", 1)
            };
            Execute(cmdInsert, parameters);
        }

        public void Atualizar(Categoria categoria)
        {
            string cmdUpdate = "UPDATE Categoria SET Descricao = @Descricao, ATIVO = @Ativo WHERE ID = @Id";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Descricao", categoria.Descricao),
                new SqlParameter("@Ativo", 1),
                new SqlParameter("@Id", categoria.Id)
            };
            Execute(cmdUpdate, parameters);
        }

        public List<Categoria> Buscar()
        {
            string cmdInsert = "SELECT DESCRICAO, ID FROM biblioteca.dbo.CATEGORIA WHERE ATIVO = 1";
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand sqlCommand = new SqlCommand(cmdInsert, con);
            con.Open();
            var reader = sqlCommand.ExecuteReader();
            List<Categoria> categorias = new List<Categoria>();
            while (reader.Read())
            {
                Categoria categoria = new Categoria();
                categoria.Descricao = reader[0].ToString();
                categoria.Id = reader.GetInt32(reader.GetOrdinal("ID"));
                categorias.Add(categoria);
            }
            con.Close();
            return categorias;
        }
    }
}
