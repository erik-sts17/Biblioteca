using Desktop_Biblioteca.DAO.Livro;
using System;
using System.Windows.Forms;

namespace Desktop_Biblioteca.Cadastro.Genero
{
    public partial class FrmCadastroGenero : Form
    {
        public FrmCadastroGenero()
        {
            InitializeComponent();
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

            try
            {
                Entidades.Livro.Genero genero = new Entidades.Livro.Genero(txtGenero.Text);
                GeneroDao dao = new GeneroDao();
                dao.Insert(genero);
                lblSucesso.Visible = true;
                btnLimpar_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao executar operação, tente novamente.");
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
