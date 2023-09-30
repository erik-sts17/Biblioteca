using Desktop_Biblioteca.DAO.Devolucao;
using Desktop_Biblioteca.DAO.Emprestimo;
using Desktop_Biblioteca.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Desktop_Biblioteca.Consulta
{
    public partial class FrmConsultaEmprestimo : Form
    {
        public Entidades.Filtro Filtro { get; set; }
        public FrmConsultaEmprestimo()
        {
            InitializeComponent();
            BuscarEmprestimos();
            cbStatus.Items.AddRange(Enum.GetNames(typeof(Status)));
            cbStatus.SelectedIndex = 0;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarEmprestimos(Entidades.Filtro filtro = null)
        {
            try
            {
                btnDevolver.Visible = false;
                if (filtro != null)
                {
                    if (filtro.Status == Status.Emprestados)
                    {
                        btnDevolver.Visible = true;
                    }
                    else if (filtro.Status == Status.Atrasados)
                    {
                        btnDevolver.Visible = true;
                    }
                }

                EmprestimoDAO dao = new EmprestimoDAO();
                List<Entidades.EmprestimoDTO> emprestimos = dao.BuscarEmprestimos(filtro);
                dgrEmprestimos.DataSource = emprestimos;
                foreach (DataGridViewColumn column in dgrEmprestimos.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao executar operação, tente novamente.");
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var filtro = new Entidades.Filtro();
            if (Enum.TryParse(cbStatus.SelectedItem.ToString(), out Status status))
                filtro.Status = status;

            else
                filtro.Status = Status.Todos;


            if (!string.IsNullOrEmpty(txtEmailCliente.Text))
                filtro.EmailCliente = txtEmailCliente.Text;

            BuscarEmprestimos(filtro);
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtEmailCliente.Text = string.Empty;
            cbStatus.SelectedIndex = 0;
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            int linhas = dgrEmprestimos.SelectedRows.Count;
            if (linhas < 1)
            {
                MessageBox.Show("Selecione um registro para devolver.");
                return;
            }

            if (linhas > 1)
            {
                MessageBox.Show("Para devolver, selecione um registro por vez.");
                return;
            }

            var emprestimoDao = new EmprestimoDAO();
            var resultado = MessageBox.Show("Tem certeza que deseja realizar a devolução?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                var emprestimoId = 0;
                foreach (DataGridViewRow row in dgrEmprestimos.SelectedRows)
                {
                    emprestimoId = Convert.ToInt32(row.Cells[0].Value);
                }
                var livros = emprestimoDao.BuscarLivrosId(emprestimoId);
                var dao = new DevolucaoDAO();
                dao.Devolver(emprestimoId, livros);
            }
            btnLimpar_Click_1(sender, e);
            BuscarEmprestimos(Filtro);
        }

        private void dgrEmprestimos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgrEmprestimos.Columns["DataEsperadaDevolucao"].Index)
            {
                if (e.Value != null && e.Value is DateTime)
                {
                    DateTime dataHora = (DateTime)e.Value;
                    e.Value = dataHora.ToShortDateString();
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
