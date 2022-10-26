using Desktop_Biblioteca.DAO.Livro;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Desktop_Biblioteca.Livro.Categoria
{
    public partial class FrmCadastroCategoria : Form
    {
        public FrmCadastroCategoria()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCategoria.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
                return;

            try
            {
                Entidades.Livro.Categoria categoria = new Entidades.Livro.Categoria(txtCategoria.Text);
                CategoriaDao dao = new CategoriaDao();
                dao.Insert(categoria);
                lblSucesso.Visible = true;
                btnLimpar_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao executar operação, tente novamente.");
            }
        }

        private void lblConfirma_Click(object sender, EventArgs e)
        {

        }

        private bool ValidaForm()
        {
            if (String.IsNullOrEmpty(txtCategoria.Text))
            {
                MessageBox.Show("Campo obrigatório!");
                return true;
            }
            return false;
        }
    }
}
