using Desktop_Biblioteca.DAO.Livro;
using System;
using System.Windows.Forms;

namespace Desktop_Biblioteca.Cadastro.Autor
{
    public partial class FrmCadastroAutor : Form
    {
        public FrmCadastroAutor()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAutor.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidaForm())
                return;

            try
            {
                Entidades.Livro.Autor autor = new Entidades.Livro.Autor(txtAutor.Text);
                AutorDao dao = new AutorDao();
                dao.Insert(autor);
                lblSucesso.Visible = true;
                btnLimpar_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao executar operação, tente novamente.");
            }
        }

        private bool ValidaForm()
        {
            if (String.IsNullOrEmpty(txtAutor.Text))
            {
                MessageBox.Show("Campo obrigatório!");
                return false;
            }
            return true;
        }
    }
}
