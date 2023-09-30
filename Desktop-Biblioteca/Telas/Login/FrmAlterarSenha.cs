using Desktop_Biblioteca.DAO.Funcionario;
using System;
using System.Windows.Forms;

namespace Desktop_Biblioteca.Login
{
    public partial class FrmAlterarSenha : Form
    {
        public string Email { get; set; }
        public FrmAlterarSenha(string email)
        {
            InitializeComponent();
            lblEmail.Text = email;  
            Email = email;
        }

        private void btnLimparUsuario_Click(object sender, EventArgs e)
        {
            txtSenha1.Clear();
            txtSenhaUser.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSenha.Checked)
            {
                txtSenhaUser.UseSystemPasswordChar = false;
                txtSenha1.UseSystemPasswordChar = false;
            }

            else
            {
                txtSenhaUser.UseSystemPasswordChar = true;
                txtSenha1.UseSystemPasswordChar = true;
            }
        }

        private bool ValidaDados()
        {
            if (string.IsNullOrEmpty(txtSenha1.Text) || string.IsNullOrEmpty(txtSenhaUser.Text))
            {
                MessageBox.Show("Campos senha e conmfirmação obrigatórios!");
                return false;
            }
            if (txtSenha1.Text.Length < 8)
            {
                MessageBox.Show("Senha precisa ter no mínimo 8 caracteres.");
                return false;
            }
            if (txtSenha1.Text != txtSenhaUser.Text)
            {
                MessageBox.Show("Os dois campos precisam ser iguais.");
                return false;
            }
            return true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidaDados())
            {
                var loginDAO = new LoginDAO();
                var login = new Entidades.Login(Email, txtSenhaUser.Text);
                loginDAO.AlterarSenha(login);
                lblSucesso.Visible = true;
                btnLimparUsuario_Click(sender, e);
            }
        }
    }
}
