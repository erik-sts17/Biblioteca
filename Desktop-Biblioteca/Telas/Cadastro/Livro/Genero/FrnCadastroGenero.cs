using Desktop_Biblioteca.DAO.Livro;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Desktop_Biblioteca.Cadastro.Genero
{
    public partial class FrmCadastroGenero : Form
    {
        public FrmCadastroGenero(Entidades.Livro.Genero genero = null)
        {
            InitializeComponent();
            if (genero != null)
            {
                lblGenero.Text = "Edição de Gênero";
                lblIdValue.Text = genero.Id.ToString();
                txtGenero.Text = genero.Descricao.ToString();
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
            txtGenero.Clear();
        }

        private void txtValorMoeda_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
                return;

            Entidades.Livro.Genero genero = new Entidades.Livro.Genero(txtGenero.Text);
            if (string.IsNullOrEmpty(lblIdValue.Text))
            {
                try
                {
                    GeneroDao dao = new GeneroDao();
                    dao.Inserir(genero);
                    lblSucesso.Visible = true;
                    btnLimpar_Click(sender, e);
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
                    genero.Id = int.Parse(lblIdValue.Text);
                    GeneroDao dao = new GeneroDao();
                    dao.Atualizar(genero);
                    lblSucesso.Visible = true;
                    btnLimpar_Click(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao executar operação, tente novamente.");
                }
            }
        }

        private void txtNomeMoeda_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblConfirma_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool ValidaForm()
        {
            if (String.IsNullOrEmpty(txtGenero.Text))
            {
                MessageBox.Show("Campo obrigatório!");
                return true;
            }
            return false;
        }
    }
}
