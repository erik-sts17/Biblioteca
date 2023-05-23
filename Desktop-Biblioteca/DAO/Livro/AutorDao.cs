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

        public List<Autor> Buscar()
        {
            string cmdInsert = "SELECT NOME, ID FROM biblioteca.dbo.Autor WHERE ATIVO = 1";
            string strConexao = "data source=DESKTOP-IBAL138;initial catalog=biblioteca;trusted_connection=true";
            SqlConnection con = new SqlConnection(strConexao);
            SqlCommand sqlCommand = new SqlCommand(cmdInsert, con);
            con.Open();
            var reader = sqlCommand.ExecuteReader();
            List<Autor> autores = new List<Autor>();
            while (reader.Read())
            {
                Autor autor = new Autor();
                autor.Nome = reader[0].ToString();
                autor.Id = reader.GetInt32(reader.GetOrdinal("ID"));
                autores.Add(autor);
            }
            con.Close();
            return autores;
        }
    }
}
