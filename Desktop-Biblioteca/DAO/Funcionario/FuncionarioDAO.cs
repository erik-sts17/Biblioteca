using Desktop_Biblioteca.DAO.Endereco;
using Desktop_Biblioteca.Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Desktop_Biblioteca.DAO.Funcionario
{
    public class FuncionarioDAO : BaseDAO
    {
        public void Insert(Entidades.Funcionario funcionario, Entidades.Login login)
        {
            SqlParameter[] parametersEndereco =
            {
                new SqlParameter("@Uf", funcionario.Endereco.Uf),
                new SqlParameter("@Cidade", funcionario.Endereco.Cidade),
                new SqlParameter("@Bairro", funcionario.Endereco.Bairro),
                new SqlParameter("@Logradouro", funcionario.Endereco.Logradouro),
                new SqlParameter("@Numero", funcionario.Endereco.Numero),
                new SqlParameter("@Complemento", funcionario.Endereco.Complemento),
                new SqlParameter("@Cep", funcionario.Endereco.Cep)
            };

            string queryEndereco = "INSERT INTO Endereco (UF, CIDADE, BAIRRO, LOGRADOURO, NUMERO, COMPLEMENTO, CEP) " +
                                    "VALUES (@Uf, @Cidade, @Bairro, @Logradouro, @Numero, @Complemento, @Cep); " +
                                    "SELECT SCOPE_IDENTITY() AS EnderecoId ";

            var loginDao = new LoginDAO();
            loginDao.Inserir(login);

            var enderecoId = ExecuteScalar(queryEndereco, parametersEndereco);

            SqlParameter[] parametersFuncionario =
           {
                new SqlParameter("@AtivoFunc", 1),
                new SqlParameter("@Nome", funcionario.Nome),
                new SqlParameter("@DataNascimento", funcionario.DataNascimento),
                new SqlParameter("@Rg", funcionario.Rg),
                new SqlParameter("@Cpf", funcionario.Cpf),
                new SqlParameter("@Email", funcionario.Email),
                new SqlParameter("@Telefone", funcionario.Telefone),
                new SqlParameter("@Senha", funcionario.Email),
                new SqlParameter("@EnderecoId", enderecoId)
            };

            string queryFunc =  "INSERT INTO Funcionario (NOME, DATANASCIMENTO, RG, CPF, EMAIL, TELEFONE, ENDERECOID, ATIVO) " +
                                "VALUES (@Nome, @DataNascimento, @Rg, @Cpf, @Email, @Telefone, @EnderecoId, @AtivoFunc)";

            Execute(queryFunc, parametersFuncionario);
        }

        public void Atualizar(Entidades.Funcionario funcionario)
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

                                UPDATE Funcionario
                                SET Nome = @Nome, 
                                    DataNascimento = @DataNascimento, 
                                    Rg = @Rg, 
                                    Cpf = @Cpf, 
                                    Email = @Email, 
                                    Telefone = @Telefone
                                WHERE Id = @Id";

            SqlParameter[] parameters =
            {
                 new SqlParameter("@Cep", funcionario.Endereco.Cep),
                 new SqlParameter("@Uf", funcionario.Endereco.Uf),
                 new SqlParameter("@Cidade", funcionario.Endereco.Cidade),
                 new SqlParameter("@Bairro", funcionario.Endereco.Bairro),
                 new SqlParameter("@Logradouro", funcionario.Endereco.Logradouro),
                 new SqlParameter("@Numero", funcionario.Endereco.Numero),
                 new SqlParameter("@Complemento", funcionario.Endereco.Complemento),
                 new SqlParameter("@EnderecoId", funcionario.Endereco.Id),
                 new SqlParameter("@Nome", funcionario.Nome),
                 new SqlParameter("@DataNascimento", funcionario.DataNascimento),
                 new SqlParameter("@Rg", funcionario.Rg),
                 new SqlParameter("@Cpf", funcionario.Cpf),
                 new SqlParameter("@Email", funcionario.Email),
                 new SqlParameter("@Telefone", funcionario.Telefone),
                 new SqlParameter("@Id", funcionario.Id),
            };

            Execute(cmdUpdate, parameters);
        }

        public List<Entidades.Funcionario> BuscarFuncionarios()
        {
            string query = "SELECT * FROM Funcionario WHERE ATIVO = 1";
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, con);
            con.Open();
            var reader = sqlCommand.ExecuteReader();
            List<Entidades.Funcionario> funcionarios = new List<Entidades.Funcionario>();
            while (reader.Read())
            {
                Entidades.Funcionario funcionario = new Entidades.Funcionario();
                funcionario.Id = reader.GetInt32(reader.GetOrdinal("ID"));
                funcionario.Nome = reader.GetString(reader.GetOrdinal("Nome"));
                funcionario.Email = reader.GetString(reader.GetOrdinal("Email"));
                funcionario.Telefone = reader.GetString(reader.GetOrdinal("Telefone"));
                funcionario.Rg = reader.GetString(reader.GetOrdinal("Rg"));
                funcionario.Cpf = reader.GetString(reader.GetOrdinal("Cpf"));
                funcionario.DataNascimento = reader.GetDateTime(reader.GetOrdinal("DataNascimento"));
                funcionarios.Add(funcionario);
            }
            return funcionarios;
        }

        public Entidades.Funcionario BuscarFuncionarioPorId(int id)
        {
            string query = "SELECT * FROM Funcionario WHERE Id = @Id AND ATIVO = 1";
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, con);
            sqlCommand.Parameters.AddWithValue("@Id", id);
            con.Open();
            var reader = sqlCommand.ExecuteReader();
            Entidades.Funcionario funcionario = new Entidades.Funcionario();
            while (reader.Read())
            {
                funcionario = new Entidades.Funcionario()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("ID")),
                    Nome = reader.GetString(reader.GetOrdinal("Nome")),
                    Email = reader.GetString(reader.GetOrdinal("Email")),
                    Telefone = reader.GetString(reader.GetOrdinal("Telefone")),
                    Rg = reader.GetString(reader.GetOrdinal("Rg")),
                    Cpf = reader.GetString(reader.GetOrdinal("Cpf")),
                    DataNascimento = reader.GetDateTime(reader.GetOrdinal("DataNascimento"))
                };
                funcionario.Endereco = new EnderecoDao().BuscarEnderecoPorId(funcionario.Id, true);
            }
            return funcionario;
        }

        public bool ExisteFuncionario(string email)
        {
            string query = $"SELECT COUNT(*) AS TOTAL FROM Funcionario WHERE Email = '{email}'";
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

        public int BuscarFuncionarioEmail(string email)
        {
            string query = $"SELECT Id FROM Funcionario WHERE Email = '{email}' AND ATIVO = 1";
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, con);
            con.Open();
            var reader = sqlCommand.ExecuteReader();
            int id = 0;
            while (reader.Read())
            {
                id = reader.GetInt32(reader.GetOrdinal("ID"));
            }
            return id;
        }
    }
}
