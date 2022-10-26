using Desktop_Biblioteca.Home;
using System;
using System.Windows.Forms;

namespace Desktop_Biblioteca.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Form1 frmHome = new Form1();
            frmHome.Show();
            this.Hide();
        }

        private void btnLimparUsuario_Click(object sender, EventArgs e)
        {
            txtEmailUser.Clear();
            txtSenhaUser.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSenha.Checked)
                txtSenhaUser.UseSystemPasswordChar = false;
            else
                txtSenhaUser.UseSystemPasswordChar = true;
        }
    }
}
