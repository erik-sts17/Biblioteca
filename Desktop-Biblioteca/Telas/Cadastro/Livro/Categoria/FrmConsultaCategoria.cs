using Desktop_Biblioteca.Cadastro.Autor;
using Desktop_Biblioteca.DAO.Livro;
using Desktop_Biblioteca.Entidades.Livro;
using Desktop_Biblioteca.Livro.Categoria;
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
            var resultado = MessageBox.Show("Tem certeza que deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
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
                    int id = Convert.ToInt32(row.Cells["Id"].Value);
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

            Categoria categoria = new Categoria();
            foreach (DataGridViewRow row in dgrCategorias.SelectedRows)
            {
                categoria.Id = Convert.ToInt32(row.Cells["Id"].Value);
                categoria.Descricao = Convert.ToString(row.Cells["Nome"].Value);
            }
            this.Close();
            FrmCadastroCategoria frmCategoria = new FrmCadastroCategoria(categoria);
            frmCategoria.Show();
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
