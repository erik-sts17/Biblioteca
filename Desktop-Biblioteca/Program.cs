using Desktop_Biblioteca.Cadastro.Cliente;
using Desktop_Biblioteca.DAO.Funcionario;
using Desktop_Biblioteca.Login;
using System;
using System.Windows.Forms;

namespace Desktop_Biblioteca
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var funcionarioDao = new FuncionarioDAO();
            if (!funcionarioDao.ExisteFuncionario())
                Application.Run(new FrmCadastroFuncionario(primeiroAcesso: true));
            
            else
                Application.Run(new FrmLogin());
        }
    }
}
