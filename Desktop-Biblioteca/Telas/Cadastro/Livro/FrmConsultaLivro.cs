using Desktop_Biblioteca.Cadastro;
using Desktop_Biblioteca.DAO.Livro;
using Desktop_Biblioteca.Entidades.Livro;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Desktop_Biblioteca.Consulta
{
    public partial class FrmConsultaLivro : Form
    {
        public List<Genero> Generos { get; set; }
        public List<Categoria> Categorias { get; set; }
        public Filtro Filtro { get; set; }
        public FrmConsultaLivro()
        {
            InitializeComponent();
            BuscarLivros();
            BuscarGenerosCategorias();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            int linhas = dgrLivros.SelectedRows.Count;
            if (linhas < 1)
            {
                MessageBox.Show("Selecione pelo menos um registro para apagar.");
                return;
            }
            List<int> ids = new List<int>();
            foreach (DataGridViewRow row in dgrLivros.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                ids.Add(id);
            }
            AutorDao dao = new AutorDao();
            try
            {
                dao.Excluir("Livro", ids);
                MessageBox.Show("Dados apagados com sucesso.");
                BuscarLivros();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao apagar registros.");
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var livro = new Entidades.Livro.Livro();
            foreach (DataGridViewRow row in dgrLivros.SelectedRows)
            {
                var id = Convert.ToInt32(row.Cells["Id"].Value);
                livro = new LivroDao().BuscarPorId(id);
            }
            var frmCadastroLivro = new FrmCadastroLivro(livro);
            this.Close();
            frmCadastroLivro.Show();
        }

        private void BuscarLivros(Filtro filtro = null)
        {
            try
            {
                LivroDao dao = new LivroDao();
                List<Entidades.Livro.Livro> livros = dao.BuscarTodos(filtro: filtro);
                dgrLivros.DataSource = livros;
                foreach (DataGridViewColumn column in dgrLivros.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                dgrLivros.Columns["Ativo"].Visible = false;
                dgrLivros.Columns["Imagem"].Visible = false;
                dgrLivros.Columns["CategoriaId"].Visible = false;
                dgrLivros.Columns["GeneroId"].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao executar operação, tente novamente.");
            }
        }
        private void BuscarGenerosCategorias()
        {
            var generoDao = new GeneroDao();
            var categoriaDao = new CategoriaDao();
            var generos = generoDao.Buscar();
            var categorias = categoriaDao.Buscar();
            Generos = generos;
            Categorias = categorias;
            foreach (var genero in generos)
            {
                cbGenero.Items.Add(genero);
            }
            foreach (var categoria in categorias)
            {
                cbCategorias.Items.Add(categoria);
            }
            cbCategorias.SelectedIndex = 0;
            cbGenero.SelectedIndex = 0;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var filtro = new Filtro();
            if (cbGenero.SelectedIndex != 0 && cbGenero.SelectedIndex != -1) 
            {
                Genero genero = (Genero)cbGenero.SelectedItem;
                filtro.GeneroId = genero.Id;
            }

            if (cbCategorias.SelectedIndex != 0 && cbCategorias.SelectedIndex != -1) 
            {
                Categoria categoria = (Categoria)cbCategorias.SelectedItem;
                filtro.CategoriaId = categoria.Id;
            }

            if (!string.IsNullOrEmpty(txtTitulo.Text))
                filtro.Titulo = txtTitulo.Text;

            BuscarLivros(filtro);
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtTitulo.Text = string.Empty;
            cbGenero.SelectedIndex = 0;
            cbCategorias.SelectedIndex = 0;
        }
    }
}
