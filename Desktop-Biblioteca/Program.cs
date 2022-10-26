using Desktop_Biblioteca.Home;
using Desktop_Biblioteca.Login;
using System;
using System.Collections.Generic;
using System.Linq;
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
            Application.Run(new FrmLogin());
        }
    }
}
