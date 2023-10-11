using Desktop_Biblioteca.Cadastro.Cliente;
using Desktop_Biblioteca.DAO.Funcionario;
using Desktop_Biblioteca.DAO.Livro;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Desktop_Biblioteca.Consulta
{
    public partial class FrmConsultaFuncionario : Form
    {
        public FrmConsultaFuncionario()
        {
            InitializeComponent();
            BuscarFuncionarios();
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
                int linhas = dgrFuncionarios.SelectedRows.Count;
                if (linhas < 1)
                {
                    MessageBox.Show("Selecione pelo menos um registro para apagar.");
                    return;
                }
                List<int> ids = new List<int>();
                foreach (DataGridViewRow row in dgrFuncionarios.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells[1].Value);
                    ids.Add(id);
                }
                AutorDao dao = new AutorDao();
                try
                {
                    dao.Excluir("AUTOR", ids);
                    MessageBox.Show("Dados apagados com sucesso.");
                    BuscarFuncionarios();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao apagar registros.");
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int linhas = dgrFuncionarios.SelectedRows.Count;
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
            int id = 0;
            foreach (DataGridViewRow row in dgrFuncionarios.SelectedRows)
            {
                id = Convert.ToInt32(row.Cells["Id"].Value);
            }
            var funcionario = new FuncionarioDAO().BuscarFuncionarioPorId(id);
            this.Close();
            FrmCadastroFuncionario frmCliente = new FrmCadastroFuncionario(funcionario);
            frmCliente.Show();
        }

        private void BuscarFuncionarios()
        {
            try
            {
                FuncionarioDAO dao = new FuncionarioDAO();
                List<Entidades.Funcionario> funcionarios = dao.BuscarFuncionarios();
                dgrFuncionarios.DataSource = funcionarios;
                dgrFuncionarios.Columns["Ativo"].Visible = false;
                dgrFuncionarios.Columns["Endereco"].Visible = false;
                dgrFuncionarios.Columns["Login"].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao executar operação, tente novamente.");
            }
        }
    }
}
