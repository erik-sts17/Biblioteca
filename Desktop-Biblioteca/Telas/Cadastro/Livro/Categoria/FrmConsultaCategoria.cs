using Desktop_Biblioteca.Cadastro.Autor;
using Desktop_Biblioteca.DAO.Livro;
using Desktop_Biblioteca.Entidades.Livro;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Desktop_Biblioteca.Consulta
{
    public partial class FrmConsultaCategoria : Form
    {
        public FrmConsultaCategoria()
        {
            InitializeComponent();
            BuscarCategorias();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            int linhas = dgrCategorias.SelectedRows.Count;
            if (linhas < 1)
            {
                MessageBox.Show("Selecione pelo menos um registro para apagar.");
                return;
            }
            List<int> ids = new List<int>();
            foreach (DataGridViewRow row in dgrCategorias.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                ids.Add(id);
            }
            CategoriaDao dao = new CategoriaDao();
            try
            {
                dao.Excluir("CATEGORIA", ids);
                MessageBox.Show("Dados apagados com sucesso.");
                BuscarCategorias();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao apagar registros.");
            }
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int linhas = dgrCategorias.SelectedRows.Count;
            if (linhas > 1)
            {
                MessageBox.Show("Para editar selecione um registro por vez.");
                return;
            }

            if (linhas < 1)
            {
                MessageBox.Show("Selecione pelo menos um registro para edição.");
                return;
            }

            Autor autor = new Autor();
            foreach (DataGridViewRow row in dgrCategorias.SelectedRows)
            {
                autor.Id = Convert.ToInt32(row.Cells[0].Value);
                autor.Nome = Convert.ToString(row.Cells[1].Value);
            }
            this.Close();
            FrmCadastroAutor frmAutor = new FrmCadastroAutor(autor);
            frmAutor.Show();
        }

        private void BuscarCategorias() 
        {
            try
            {
                CategoriaDao dao = new CategoriaDao();
                var categorias = dao.Buscar();
                dgrCategorias.DataSource = categorias;
                dgrCategorias.Columns["Ativo"].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao executar operação, tente novamente.");
            }
        }
    }
}
