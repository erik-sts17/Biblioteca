using System.Data.SqlClient;

namespace Desktop_Biblioteca.DAO.Endereco
{
    public class EnderecoDao : BaseDAO
    {
        public Entidades.Endereco BuscarEnderecoPorId(int id, bool funcionario = false)
        {
            var query = "SELECT * FROM Endereco E ";
            if (funcionario)
            {
                query += $" INNER JOIN Funcionario F ON E.Id = F.EnderecoId WHERE F.Ativo = 1 AND F.Id = {id}";
            }
            else 
            {
                query += $" INNER JOIN Cliente C ON E.Id = C.EnderecoId WHERE C.Ativo = 1 AND C.Id = {id}";
            }
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, con);
            con.Open();
            var reader = sqlCommand.ExecuteReader();
            Entidades.Endereco endereco = null;
            while (reader.Read())
            {
                endereco = new Entidades.Endereco()
                {
                    Id = (int)reader["Id"],
                    Uf = (string)reader["Uf"],
                    Cidade = (string)reader["Cidade"],
                    Bairro = (string)reader["Bairro"],
                    Logradouro = (string)reader["Logradouro"],
                    Numero = (string)reader["Numero"],
                    Complemento = (string)reader["Complemento"],
                    Cep = (string)reader["Cep"],
                };
            }
            con.Close();
            return endereco;
        }
    }
}
