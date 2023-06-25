using System.Data.SqlClient;

namespace Desktop_Biblioteca.DAO.Funcionario
{
    public class FuncionarioDAO : BaseDAO
    {
        public void Insert(Entidades.Funcionario funcionario)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@Uf", funcionario.Endereco.Uf),
                new SqlParameter("@Cidade", funcionario.Endereco.Cidade),
                new SqlParameter("@Bairro", funcionario.Endereco.Bairro),
                new SqlParameter("@Logradouro", funcionario.Endereco.Logradouro),
                new SqlParameter("@Numero", funcionario.Endereco.Numero),
                new SqlParameter("@Complemento", funcionario.Endereco.Complemento),
                new SqlParameter("@AtivoFunc", 1),
                new SqlParameter("@Nome", funcionario.Nome),
                new SqlParameter("@DataNascimento", funcionario.DataNascimento),
                new SqlParameter("@Rg", funcionario.Rg),
                new SqlParameter("@Cpf", funcionario.Cpf),
                new SqlParameter("@Email", funcionario.Email),
                new SqlParameter("@Telefone", funcionario.Telefone),
            };

            string query = "INSERT INTO Endereco (UF, CIDADE, BAIRRO, LOGRADOURO, NUMERO, COMPLEMENTO) " +
                           "VALUES (@Uf, @Cidade, @Bairro, @Logradouro, @Numero, @Complemento);" +
                           "DECLARE @EnderecoId INT = CAST(scope_identity() AS int);" +
                           "INSERT INTO Funcionario (NOME, DATANASCIMENTO, RG, CPF, EMAIL, TELEFONE, ENDERECOID, ATIVO) " +
                           "VALUES (@Nome, @DataNascimento, @Rg, @Cpf, @Email, @Telefone, @EnderecoId, @AtivoFunc)";

            Execute(query, parameters);
        }
    }
}
