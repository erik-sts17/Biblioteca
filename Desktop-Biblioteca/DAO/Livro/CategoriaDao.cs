using Desktop_Biblioteca.Entidades.Livro;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Desktop_Biblioteca.DAO.Livro
{
    public class CategoriaDao
    {
        public void Insert(Categoria categoria)
        {
            string cmdInsert = " INSERT INTO Categoria (DESCRICAO, ATIVO) VALUES ('" + categoria.Descricao + "', '" + 1 + "')";
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

        public List<Categoria> Buscar()
        {
            string cmdInsert = "SELECT DESCRICAO, ID FROM biblioteca.dbo.CATEGORIA WHERE ATIVO = 1";
            string strConexao = "data source=DESKTOP-3ILN32B;initial catalog=biblioteca;trusted_connection=true";
            SqlConnection con = new SqlConnection(strConexao);
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
