using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Desktop_Biblioteca.DAO.Cliente
{
    public class ClienteDao
    {
        public void Insert(Entidades.Cliente cliente)
        {
            string cmdInsertEndereco = " INSERT INTO Endereco (UF, CIDADE, BAIRRO, LOGRADOURO, NUMERO, COMPLEMENTO, ATIVO) VALUES ('" + cliente.Endereco.Uf + "' , '" + cliente.Endereco.Cidade + "', '" + cliente.Endereco.Bairro + "', '" + cliente.Endereco.Logradouro + "' , '" + cliente.Endereco.Numero + "', '" + cliente.Endereco.Complemento + "', '" + 1 + "') ";
            string cmdInsertCliente = " INSERT INTO Cliente (NOME, DATANASCIMENTO, RG, EMAIL, TELEFONE, ENDERECOID, ATIVO) VALUES ('" + cliente.Nome + "', '" + cliente.DataNascimento + "', '" + cliente.Rg + "', '" + cliente.Email + "', '" + cliente.Telefone + "', (SELECT IDENT_CURRENT('biblioteca.dbo.Endereco')) , '" + 1 + "') ";
            string strConexao = ConfigurationManager.AppSettings["ConnectionString"];
            try
            {
                SqlConnection con = new SqlConnection(strConexao);
                SqlCommand sqlCommand = new SqlCommand(cmdInsertEndereco + cmdInsertCliente, con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
