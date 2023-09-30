using Desktop_Biblioteca.DAO.Endereco;
using Desktop_Biblioteca.DAO.Funcionario;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Desktop_Biblioteca.DAO.Cliente
{
    public class ClienteDao : BaseDAO
    {
        public void Insert(Entidades.Cliente cliente, Entidades.Login login)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@Cep", cliente.Endereco.Cep),
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

            var loginDao = new LoginDAO();
            loginDao.Inserir(login);

            string query = "INSERT INTO Endereco (Cep, UF, CIDADE, BAIRRO, LOGRADOURO, NUMERO, COMPLEMENTO) " +
                           "VALUES (@Cep, @Uf, @Cidade, @Bairro, @Logradouro, @Numero, @Complemento);" +
                           "DECLARE @EnderecoId INT = CAST(scope_identity() AS int);" +
                           "INSERT INTO Cliente (NOME, DATANASCIMENTO, RG, EMAIL, TELEFONE, ENDERECOID, ATIVO) " +
                           "VALUES (@Nome, @DataNascimento, @Rg, @Email, @Telefone, @EnderecoId, @AtivoCli)";

            Execute(query, parameters);
        }

        public void Atualizar(Entidades.Cliente cliente)
        {
            string cmdUpdate = @"UPDATE Endereco
                                SET Cep = @Cep, 
                                    Uf = @Uf, 
                                    Cidade = @Cidade, 
                                    Bairro = @Bairro, 
                                    Logradouro = @Logradouro, 
                                    Numero = @Numero, 
                                    Complemento = @Complemento
                                WHERE Id = @EnderecoId;

                                UPDATE Cliente
                                SET Nome = @Nome, 
                                    DataNascimento = @DataNascimento, 
                                    Rg = @Rg, 
                                    Email = @Email, 
                                    Telefone = @Telefone
                                WHERE Id = @Id

                                UPDATE Login
                                    SET Senha = @Senha
                                WHERE Email = @Email";

            SqlParameter[] parameters =
            {
                 new SqlParameter("@Cep", cliente.Endereco.Cep),
                 new SqlParameter("@Uf", cliente.Endereco.Uf),
                 new SqlParameter("@Cidade", cliente.Endereco.Cidade),
                 new SqlParameter("@Bairro", cliente.Endereco.Bairro),
                 new SqlParameter("@Logradouro", cliente.Endereco.Logradouro),
                 new SqlParameter("@Numero", cliente.Endereco.Numero),
                 new SqlParameter("@Complemento", cliente.Endereco.Complemento),
                 new SqlParameter("@EnderecoId", cliente.Endereco.Id),
                 new SqlParameter("@Nome", cliente.Nome),
                 new SqlParameter("@DataNascimento", cliente.DataNascimento),
                 new SqlParameter("@Rg", cliente.Rg),
                 new SqlParameter("@Email", cliente.Email),
                 new SqlParameter("@Telefone", cliente.Telefone),
                 new SqlParameter("@Id", cliente.Id),
                 new SqlParameter("@Senha", cliente.Senha)
            };

            Execute(cmdUpdate, parameters);
        }

        public bool ExisteCliente(string email)
        {
            string query = $"SELECT COUNT(*) AS TOTAL FROM Cliente WHERE Email = '{email}' AND ATIVO = 1";
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, con);
            con.Open();
            var reader = sqlCommand.ExecuteReader();
            var total = 0;
            while (reader.Read())
            {
                total = reader.GetInt32(reader.GetOrdinal("TOTAL"));
            }
            if (total > 0)
                return true;
            return false;
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

        public Entidades.Cliente BuscarPorId(int id)
        {
            string query = "SELECT * FROM Cliente WHERE Id = @Id AND ATIVO = 1";
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, con);
            sqlCommand.Parameters.AddWithValue("@Id", id);
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
                cliente.Senha = new LoginDAO().ObterSenhaCliente(cliente.Email);
                cliente.Endereco = new EnderecoDao().BuscarEnderecoPorId(cliente.Id);
            }
            con.Close();
            return cliente;
        }


        public List<Entidades.Cliente> BuscarClientes()
        {
            string query = "SELECT * FROM Cliente WHERE ATIVO = 1";
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, con);
            con.Open();
            var reader = sqlCommand.ExecuteReader();
            List<Entidades.Cliente> clientes = new List<Entidades.Cliente>();
            while (reader.Read())
            {
                clientes.Add(new Entidades.Cliente()
                {
                    Id = (int)reader["Id"],
                    Nome = (string)reader["Nome"],
                    DataNascimento = (DateTime)reader["DataNascimento"],
                    Rg = (string)reader["Rg"],
                    Email = (string)reader["Email"],
                    Telefone = (string)reader["Telefone"],
                });
            }
            con.Close();
            return clientes;
        }
    }
}