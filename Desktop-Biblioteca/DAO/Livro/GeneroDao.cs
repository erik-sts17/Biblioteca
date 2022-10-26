﻿using Desktop_Biblioteca.Entidades.Livro;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Desktop_Biblioteca.DAO.Livro
{
    public class GeneroDao
    {
        public void Insert(Genero genero)
        {
            string cmdInsert = " INSERT INTO Genero (DESCRICAO, ATIVO) VALUES ('" + genero.Descricao + "', '" + 1 + "')";
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

        public List<Genero> Buscar()
        {
            string cmdInsert = "SELECT DESCRICAO, ID FROM biblioteca.dbo.GENERO WHERE ATIVO = 1";
            string strConexao = "data source=DESKTOP-3ILN32B;initial catalog=biblioteca;trusted_connection=true";
            SqlConnection con = new SqlConnection(strConexao);
            SqlCommand sqlCommand = new SqlCommand(cmdInsert, con);
            con.Open();
            var reader = sqlCommand.ExecuteReader();
            List<Genero> generos = new List<Genero>();
            while (reader.Read())
            {
                Genero genero = new Genero();
                genero.Descricao = reader[0].ToString();
                genero.Id = reader.GetInt32(reader.GetOrdinal("ID"));
                generos.Add(genero);
            }
            con.Close();
            return generos;
        }
    }
}
