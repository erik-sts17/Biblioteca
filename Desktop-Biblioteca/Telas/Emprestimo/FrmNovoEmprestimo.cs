using Desktop_Biblioteca.DAO.Cliente;
using Desktop_Biblioteca.DAO.Emprestimo;
using Desktop_Biblioteca.DAO.Livro;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Desktop_Biblioteca.Cadastro.Emprestimo
{
    public partial class FrmNovoEmprestimo : Form
    {
        public int ClienteId { get; set; }
        public int FuncionarioId { get; set; }
        public List<Entidades.Livro.Livro> LivrosDisponiveis { get; set; }
        public List<int> LivrosSelecionados { get; set; }
        public FrmNovoEmprestimo(int funcionarioId)
        {
            InitializeComponent();
            BuscarTodosLivros();
            FuncionarioId = funcionarioId;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LivrosSelecionados = new List<int>();
            ClienteId = 0;
            txtEmail.Text = string.Empty;
            txtRg.Text = string.Empty;
            txtNome.Text = string.Empty;
            confirmacaoEmprestimo.Visible = false;
            for (int i = 0; i < livrosDisponiveis.Items.Count; i++)
            {
                livrosDisponiveis.SetItemChecked(i, false);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
                return;

            try
            {
                var emprestimo = new Entidades.Emprestimo(ClienteId, FuncionarioId, dtDataDevolucao.Value);
                var dao = new EmprestimoDAO();
                if (dao.VerificarEmprestimoAtivo(ClienteId))
                {
                    MessageBox.Show("Já exite um empréstimo ativo para o cliente selecionado.");
                    return;
                }
                dao.Inserir(emprestimo, LivrosSelecionados);
                lblSucesso.Visible = true;
                btnLimpar_Click(sender, e);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Erro ao executar operação, tente novamente.");
            }
        }

        private bool ValidaForm()
        {
            string mensagem = "";
            List<string> erros = new List<string>();

            if (ClienteId == 0)
                erros.Add("Busque um cliente existente!");

            if (LivrosSelecionados == null || LivrosSelecionados.Count == 0)
                erros.Add("Confirme um livro para empréstimo!");

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

        private void FrmCadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void BuscarTodosLivros()
        {
            var dao = new LivroDao();
            LivrosDisponiveis = dao.BuscarTodos(true);
            foreach (var livro in LivrosDisponiveis)
            {
                livrosDisponiveis.Items.Add(livro, false);
            }
            if (LivrosDisponiveis.Count == 0)
            {
                livrosDisponiveis.Visible = false;
                lblSemLivros.Visible = true;
                btnAdicionaLivro.Visible = false;
            }
        }

        private void btnBuscaCliente_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Preencha o email do cliente");
                return;
            }
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Email inválido!");
                return;
            }
            var dao = new ClienteDao();
            var cliente = dao.BuscarPorEmail(txtEmail.Text);
            if (cliente == null)
            {
                lblErro.Visible = true;
            }
            else
            {
                lblErro.Visible = false;
                ClienteId = cliente.Id;
                txtNome.Text = cliente.Nome;
                txtRg.Text = cliente.Rg;
            }
        }

        private void btnAdicionaLivro_Click(object sender, EventArgs e)
        {
            int totalPaginas = 0;
            var livrosSelecionados = livrosDisponiveis.CheckedItems;
            if (livrosSelecionados.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um livro!");
                return;
            }
            if (livrosSelecionados.Count > 3)
            {
                MessageBox.Show("Máximo três livros por cliente!");
                return;
            }
            LivrosSelecionados = new List<int>();
            foreach (Entidades.Livro.Livro livroSelecionado in livrosSelecionados)
            {
                LivrosSelecionados.Add(livroSelecionado.Id);
                totalPaginas = totalPaginas + livroSelecionado.Paginas;
            }
            int diasNecessarios = (int)Math.Ceiling((double)totalPaginas / 5);
            var dataMaxima = DateTime.Now.AddDays(diasNecessarios);
            dtDataDevolucao.Value = dataMaxima;
            txtTotalPaginas.Text = totalPaginas.ToString();
            txtTotalLivros.Text = LivrosSelecionados.Count.ToString();
            confirmacaoEmprestimo.Visible = true;
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
