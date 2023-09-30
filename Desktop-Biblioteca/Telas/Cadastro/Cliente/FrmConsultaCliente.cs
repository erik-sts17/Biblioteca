using Desktop_Biblioteca.Cadastro.Cliente;
using Desktop_Biblioteca.DAO.Cliente;
using Desktop_Biblioteca.DAO.Livro;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Desktop_Biblioteca.Consulta
{
    public partial class FrmConsultaCliente : Form
    {
        public FrmConsultaCliente()
        {
            InitializeComponent();
            BuscarClientes();
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
                int linhas = dgrClientes.SelectedRows.Count;
                if (linhas < 1)
                {
                    MessageBox.Show("Selecione pelo menos um registro para apagar.");
                    return;
                }
                List<int> ids = new List<int>();
                foreach (DataGridViewRow row in dgrClientes.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells["Id"].Value);
                    ids.Add(id);
                }
                ClienteDao dao = new ClienteDao();
                try
                {
                    dao.Excluir("Cliente", ids);
                    MessageBox.Show("Dados apagados com sucesso.");
                    BuscarClientes();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao apagar registros.");
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int linhas = dgrClientes.SelectedRows.Count;
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
            foreach (DataGridViewRow row in dgrClientes.SelectedRows)
            {
                id = Convert.ToInt32(row.Cells["Id"].Value);
            }
            var cliente = new ClienteDao().BuscarPorId(id);
            this.Close();
            FrmCadastroCliente frmCliente = new FrmCadastroCliente(cliente);
            frmCliente.Show();
        }

        private void BuscarClientes()
        {
            try
            {
                ClienteDao dao = new ClienteDao();
                List<Entidades.Cliente> clientes = dao.BuscarClientes();
                dgrClientes.DataSource = clientes;
                dgrClientes.Columns["Ativo"].Visible = false;
                dgrClientes.Columns["Endereco"].Visible = false;
                dgrClientes.Columns["Senha"].Visible = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar operação, tente novamente.");
            }
        }
    }
}
