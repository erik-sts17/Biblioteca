using Desktop_Biblioteca.DAO.Livro;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Desktop_Biblioteca.Cadastro.Autor
{
    public partial class FrmCadastroAutor : Form
    {
        public FrmCadastroAutor(Entidades.Livro.Autor autor = null)
        {
            InitializeComponent();
            if (autor != null)
            {
                lblCadastroAutor.Text = "Edição de Autor";
                lblIdValue.Text = autor.Id.ToString();
                txtAutor.Text = autor.Nome.ToString();   
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
            txtAutor.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidaForm())
                return;

            AutorDao dao = new AutorDao();
            if (!String.IsNullOrEmpty(lblId.Text))
            {
                try
                {
                    Entidades.Livro.Autor autor = new Entidades.Livro.Autor(txtAutor.Text, int.Parse(lblIdValue.Text));
                    dao.Atualizar(autor);
                    lblSucesso.Visible = true;
                    return;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao executar operação, tente novamente.");
                }
            }

            try
            {
                Entidades.Livro.Autor autor = new Entidades.Livro.Autor(txtAutor.Text);
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

        private void txtAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
