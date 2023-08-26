using Desktop_Biblioteca.DAO.Funcionario;
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
            ValidaDados();
            var loginDAO = new LoginDAO();
            var login = new Entidades.Login(txtEmailUser.Text, txtSenhaUser.Text);
            if (loginDAO.ValidaLogin(login))
            {
                Form1 frmHome = new Form1();
                frmHome.Show();
                this.Hide();
            }
            else
            {
                lblErro.Visible = true;
            }
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

        private void ValidaDados()
        {
            if (string.IsNullOrEmpty(txtEmailUser.Text) || string.IsNullOrEmpty(txtSenhaUser.Text))
            {
                MessageBox.Show("Campos email e senha obrigatórios!");
            }
        }
    }
}
