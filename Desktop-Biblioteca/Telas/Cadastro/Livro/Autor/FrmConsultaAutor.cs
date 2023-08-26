using Desktop_Biblioteca.Cadastro.Autor;
using Desktop_Biblioteca.DAO.Livro;
using Desktop_Biblioteca.Entidades.Livro;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Desktop_Biblioteca.Consulta
{
    public partial class FrmConsultaAutor : Form
    {
        public FrmConsultaAutor()
        {
            InitializeComponent();
            BuscarAutores();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            int linhas = dgrAutores.SelectedRows.Count;
            if (linhas < 1)
            {
                MessageBox.Show("Selecione pelo menos um registro para apagar.");
                return;
            }
            List<int> ids = new List<int>();
            foreach (DataGridViewRow row in dgrAutores.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[1].Value);
                ids.Add(id);
            }
            AutorDao dao = new AutorDao();
            try
            {
                dao.Excluir("AUTOR", ids);
                MessageBox.Show("Dados apagados com sucesso.");
                BuscarAutores();
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
            int linhas = dgrAutores.SelectedRows.Count;
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
            foreach (DataGridViewRow row in dgrAutores.SelectedRows)
            {
                autor.Id = Convert.ToInt32(row.Cells[1].Value);
                autor.Nome = Convert.ToString(row.Cells[0].Value);
            }
            this.Close();
            FrmCadastroAutor frmAutor = new FrmCadastroAutor(autor);
            frmAutor.Show();
        }

        private void BuscarAutores()
        {
            try
            {
                AutorDao dao = new AutorDao();
                var autores = dao.Buscar();
                dgrAutores.DataSource = autores;
                dgrAutores.Columns["Ativo"].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao executar operação, tente novamente.");
            }
        }
    }
}
