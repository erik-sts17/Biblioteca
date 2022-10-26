using Desktop_Biblioteca.Entidades.Livro;
using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using System.Configuration;

namespace Desktop_Biblioteca.DAO.Livro
{
    public class AutorDao
    {
        public void Insert(Autor autor)
        {
            string cmdInsert = " INSERT INTO Autor (NOME, ATIVO) VALUES ('" + autor.Nome + "', '" + 1 + "')";
            string strConexao = ConfigurationManager.AppSettings["ConnectionString"];
            try
            {
                SqlConnection con = new SqlConnection(strConexao);
                SqlCommand sqlCommand = new SqlCommand(cmdInsert, con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Autor> Buscar()
        {
            string cmdInsert = "SELECT NOME, ID FROM biblioteca.dbo.Autor WHERE ATIVO = 1";
            string strConexao = "data source=DESKTOP-3ILN32B;initial catalog=biblioteca;trusted_connection=true";
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
