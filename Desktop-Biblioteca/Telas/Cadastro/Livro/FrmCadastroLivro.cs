using System;
using System.Windows.Forms;
using Desktop_Biblioteca.DAO.Livro;
using System.Collections.Generic;
using Desktop_Biblioteca.Livro.Categoria;
using Desktop_Biblioteca.Cadastro.Genero;
using Desktop_Biblioteca.Cadastro.Autor;
using System.Drawing;
using System.IO;

namespace Desktop_Biblioteca.Cadastro
{
    public partial class FrmCadastroLivro : Form
    {
        public List<Entidades.Livro.Autor> Autores { get; set; }
        public List<Entidades.Livro.Genero> Generos { get; set; }
        public List<Entidades.Livro.Categoria> Categorias { get; set; }
        public string NomeImagem { get; set; }

        public FrmCadastroLivro()
        {
            InitializeComponent();
        }

        private void buttonLimpa_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtPaginas.Clear();
            cbxCategoria.SelectedIndex = -1;
            cbxGenero.SelectedIndex = -1;
            for (int i = 0; i < checkedAutores.Items.Count; i++)
            {
                checkedAutores.SetItemChecked(i, false);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
                return;

            var categoria = (Entidades.Livro.Categoria)cbxCategoria.SelectedItem;
            var genero = (Entidades.Livro.Genero)cbxGenero.SelectedItem;

            List<int> autoresSelecionados = new List<int>();

            foreach (Entidades.Livro.Autor autorSelecionado in checkedAutores.CheckedItems)
            {
                autoresSelecionados.Add(autorSelecionado.Id);
            }

            byte[] imageBytes = null;
            if (NomeImagem != null)
                imageBytes = File.ReadAllBytes(NomeImagem);

            Entidades.Livro.Livro livro = new Entidades.Livro.Livro(txtNome.Text, categoria.Id, genero.Id, Convert.ToInt32(txtPaginas.Text), imageBytes, int.Parse(txtQuantidade.Text));
            try
            {
                LivroDao dao = new LivroDao();
                dao.Insert(livro, autoresSelecionados);
                buttonLimpa_Click(sender, e);
                lblSucesso.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao executar operação, tente novamente.");
            }
        }

        private void FrmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            var autorDao = new AutorDao();
            var generoDao = new GeneroDao();
            var categoriaDao = new CategoriaDao();
            var autores = autorDao.Buscar();
            var generos = generoDao.Buscar();
            var categorias = categoriaDao.Buscar();
            Autores = autores;
            Generos = generos;
            Categorias = categorias;
            foreach (var autor in autores)
            {
                checkedAutores.Items.Add(autor, false);
            }
            foreach (var genero in generos)
            {
                cbxGenero.Items.Add(genero);
            }
            foreach (var categoria in categorias)
            {
                cbxCategoria.Items.Add(categoria);
            }
            if (Autores == null || this.Autores.Count == 0)
            {
                checkedAutores.Visible = false;
                btnAdicionaAutor.Visible = true;
            }

            if (this.Categorias == null || this.Categorias.Count == 0)
            {
                cbxCategoria.Visible = false;
                btnAdicionaCategoria.Visible = true;
            }

            if (this.Generos == null || this.Generos.Count == 0)
            {
                cbxGenero.Visible = false;
                btnAdicionaGenero.Visible = true;
            }
        }

        private bool ValidaForm()
        {
            string mensagem = "";
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtPaginas.Text))
                erros.Add("Campos com '*' são obrigatórios!");
             
            if (cbxGenero.SelectedIndex == -1)
                erros.Add("Selecione um Genero");


            if (cbxCategoria.SelectedIndex == -1)
                erros.Add("Selecione uma Categoria");

            var autores = checkedAutores.CheckedItems;
            if (autores.Count == 0)
                erros.Add("Selecione um Autor");
               
            if (erros.Count > 0)
            {
                foreach (var erro in erros)
                {
                    mensagem += "- " + erro + "\n";
                }
                MessageBox.Show(mensagem);
                return true;
            }

            return false;
        }


        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionaCategoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCadastroCategoria frmCadastroCategoria = new FrmCadastroCategoria();
            frmCadastroCategoria.Show();
        }

        private void btnAdicionaGenero_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCadastroGenero frmCadastroGenero = new FrmCadastroGenero();
            frmCadastroGenero.Show();
        }

        private void btnAdicionaAutor_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCadastroAutor frmCadastroAutor = new FrmCadastroAutor();
            frmCadastroAutor.Show();
        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image image = Image.FromFile(openFileDialog.FileName);
                    pbxCliente.Image = image;
                    NomeImagem = openFileDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar a imagem: " + ex.Message);
                }
            }
        }

        private void txtPaginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
