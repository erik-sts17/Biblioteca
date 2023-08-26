using Desktop_Biblioteca.Entidades.Livro;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Desktop_Biblioteca.DAO.Cliente
{
    public class ClienteDao : BaseDAO
    {
        public void Insert(Entidades.Cliente cliente)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@Uf", cliente.Endereco.Uf),
                new SqlParameter("@Cidade", cliente.Endereco.Cidade),
                new SqlParameter("@Bairro", cliente.Endereco.Bairro),
                new SqlParameter("@Logradouro", cliente.Endereco.Logradouro),
                new SqlParameter("@Numero", cliente.Endereco.Numero),
                new SqlParameter("@Complemento", cliente.Endereco.Complemento),
                new SqlParameter("@AtivoCli", 1),
                new SqlParameter("@Nome", cliente.Nome),
                new SqlParameter("@DataNascimento", cliente.DataNascimento),
                new SqlParameter("@Rg", cliente.Rg),
                new SqlParameter("@Email", cliente.Email),
                new SqlParameter("@Telefone", cliente.Telefone),
            };

            string query = "INSERT INTO Endereco (UF, CIDADE, BAIRRO, LOGRADOURO, NUMERO, COMPLEMENTO) " +
                           "VALUES (@Uf, @Cidade, @Bairro, @Logradouro, @Numero, @Complemento);" +
                           "DECLARE @EnderecoId INT = CAST(scope_identity() AS int);" +
                           "INSERT INTO Cliente (NOME, DATANASCIMENTO, RG, EMAIL, TELEFONE, ENDERECOID, ATIVO) " +
                           "VALUES (@Nome, @DataNascimento, @Rg, @Email, @Telefone, @EnderecoId, @AtivoCli)";

            Execute(query, parameters);
        }

        public Entidades.Cliente BuscarPorEmail(string email) 
        {
            string query = "SELECT * FROM Cliente WHERE Email = @Email AND ATIVO = 1";
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, con);
            sqlCommand.Parameters.AddWithValue("@Email", email);
            con.Open();
            var reader = sqlCommand.ExecuteReader();
            Entidades.Cliente cliente = null;
            while (reader.Read())
            {
                cliente = new Entidades.Cliente() 
                {
                    Id = (int)reader["Id"],
                    Nome = (string)reader["Nome"],
                    DataNascimento = (DateTime)reader["DataNascimento"],
                    Rg = (string)reader["Rg"],
                    Email = (string)reader["Email"],
                    Telefone = (string)reader["Telefone"],
                };
            }
            con.Close();
            return cliente;
        }
    }
}