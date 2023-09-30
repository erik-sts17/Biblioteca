using Desktop_Biblioteca.DAO.Livro;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Desktop_Biblioteca.Livro.Categoria
{
    public partial class FrmCadastroCategoria : Form
    {
        public FrmCadastroCategoria(Entidades.Livro.Categoria categoria = null)
        {
            InitializeComponent();
            if (categoria != null)
            {
                lblCategoria.Text = "Edição de Categoria";
                lblIdValue.Text = categoria.Id.ToString();
                txtCategoria.Text = categoria.Descricao.ToString();
                lblId.Visible = true;
                lblIdValue.Visible = true;
                lblIdValue.ForeColor = Color.White;
                btnSalvar.Text = "Editar";
                btnSalvar.BackColor = Color.Yellow;
                btnSalvar.ForeColor = Color.Black;
                lblSucesso.ForeColor = Color.Yellow;
                lblSucesso.Text = "Dados alterados com sucesso!";
            }
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

            CategoriaDao dao = new CategoriaDao();
            if (!string.IsNullOrEmpty(lblIdValue.Text))
            {
                try
                {
                    Entidades.Livro.Categoria categoria = new Entidades.Livro.Categoria(txtCategoria.Text, int.Parse(lblIdValue.Text));
                    dao.Atualizar(categoria);
                    lblSucesso.Visible = true;
                    return;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao executar operação, tente novamente.");
                }
            }
            else
            {
                try
                {
                    Entidades.Livro.Categoria categoria = new Entidades.Livro.Categoria(txtCategoria.Text);
                    dao.Inserir(categoria);
                    lblSucesso.Visible = true;
                    btnLimpar_Click(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao executar operação, tente novamente.");
                }
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
