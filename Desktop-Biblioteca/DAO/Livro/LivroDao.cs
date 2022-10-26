using System.Configuration;
using System.Data.SqlClient;

namespace Desktop_Biblioteca.DAO.Livro
{
    public class LivroDao
    {
        public void Insert(Entidades.Livro.Livro livro)
        {
            string cmdInsert = " INSERT INTO LIVRO (TITULO, CATEGORIAID, GENEROID, PAGINAS, ATIVO) "
                                + " VALUES ('" + livro.Titulo + "', '" + livro.CategoriaId + "', '" + livro.GeneroId + "', '" + livro.Paginas + "', '" + 1 + "')"
                                + " INSERT INTO AUTORESLIVROS(AUTORID, LIVROID)  VALUES ('" + livro.AutorId + "', (SELECT IDENT_CURRENT('biblioteca.dbo.LIVRO')))";
            string strConexao = ConfigurationManager.AppSettings["ConnectionString"];
            try
            {
                SqlConnection con = new SqlConnection(strConexao);
                SqlCommand sqlCommand = new SqlCommand(cmdInsert, con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
    }
}
