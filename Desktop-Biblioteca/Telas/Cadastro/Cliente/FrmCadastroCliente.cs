using Desktop_Biblioteca.Client;
using Desktop_Biblioteca.Client.Models;
using Desktop_Biblioteca.DAO.Cliente;
using Desktop_Biblioteca.DAO.Funcionario;
using Desktop_Biblioteca.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Desktop_Biblioteca.Cadastro.Cliente
{
    public partial class FrmCadastroCliente : Form
    {
        public bool Edicao { get; set; }
        public FrmCadastroCliente(Entidades.Cliente cliente = null)
        {
            InitializeComponent();
            if (cliente != null)
            {
                lblCadastroCliente.Text = "Edição de Cliente";
                btnSalvar.Text = "Editar";
                btnSalvar.BackColor = Color.Yellow;
                btnSalvar.ForeColor = Color.Black;
                lblSucesso.ForeColor = Color.Yellow;
                lblSucesso.Text = "Dados alterados com sucesso!";
                txtNome.Text = cliente.Nome;
                txtEmail.Text = cliente.Email;
                txtSenhaUser.Text = cliente.Senha;
                txtRg.Text = cliente.Rg;
                txtTelefone.Text = cliente.Telefone;
                txtEndereco.Text = cliente.Endereco.Logradouro;
                dtDataNascimento.Value = cliente.DataNascimento;
                txtBairro.Text = cliente.Endereco.Bairro;
                txtComplemento.Text = cliente.Endereco.Complemento;
                txtNumero.Text = cliente.Endereco.Numero;
                cbUf.Text = cliente.Endereco.Uf;
                txtCep.Text = cliente.Endereco.Cep;
                txtCidade.Text = cliente.Endereco.Cidade;
                Edicao = true;
                enderecoId.Text = cliente.Endereco.Id.ToString();
                clienteId.Text = cliente.Id.ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            txtRg.Clear();
            txtSenhaUser.Clear();
            txtComplemento.Clear();
            dtDataNascimento.Value = DateTime.Now;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var existeErro = ValidaForm();
            if (existeErro)
                return;

            var endereco = new Endereco(txtCep.Text, cbUf.SelectedItem.ToString(), txtCidade.Text, txtBairro.Text, txtEndereco.Text, txtNumero.Text, txtComplemento.Text);
            var cliente = new Entidades.Cliente(txtNome.Text, dtDataNascimento.Value, txtRg.Text, txtEmail.Text, txtTelefone.Text, endereco);
            ClienteDao dao = new ClienteDao();

            try
            {
                if (Edicao)
                {
                    cliente.Senha = txtSenhaUser.Text;
                    cliente.Id = int.Parse(clienteId.Text);
                    cliente.Endereco.Id = int.Parse(enderecoId.Text);
                    dao.Atualizar(cliente);
                }
                else
                {
                    var login = new Entidades.Login(txtEmail.Text, txtSenhaUser.Text);
                    var clienteDao = new ClienteDao();
                    clienteDao.Insert(cliente, login);
                }
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
            string[] textForms = new string[] { txtSenhaUser.Text, txtNome.Text, txtEmail.Text, txtRg.Text, txtTelefone.Text, txtCep.Text, txtCidade.Text, txtBairro.Text, txtEndereco.Text, txtNumero.Text };

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                var clienteDao = new ClienteDao();
                var funcionarioDao = new FuncionarioDAO();
                if (clienteDao.ExisteCliente(txtEmail.Text) || funcionarioDao.ExisteFuncionario(txtEmail.Text))
                {
                    erros.Add($"Email {txtEmail.Text} já cadastrado.");
                }
            }

            if (!string.IsNullOrEmpty(txtSenhaUser.Text))
            {
                if (txtSenhaUser.Text.Length < 8)
                    erros.Add("Senha precisa ter no mínimo 8 caracteres!");
            }

            if (textForms.Any(x => String.IsNullOrEmpty(x)))
                erros.Add("Campos com '*' são obrigatórios!");

            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                erros.Add("Email inválido!");

            var idade = DateTime.Now.Year - dtDataNascimento.Value.Year;
            if (idade < 14)
                erros.Add("Cadastro permitido apenas para maiores de 14 anos!");

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

        private void cbUf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscaCep_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCep.Text) || txtCep.Text.Length < 8)
            {
                MessageBox.Show("Preencha o campo CEP antes");
                return;
            }
            var baseClient = new BaseClient();
            var url = $"https://viacep.com.br/ws/{txtCep.Text}/json/";
            var endereco = baseClient.GetApi<CepModel>(url);
            if (endereco.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Erro ao buscar CEP, tente novamente");
                return;
            }
            if (endereco.Entity.Erro)
            {
                MessageBox.Show("CEP inválido, verifique o campo e tente novamente");
                return;
            }
            txtCidade.Text = endereco.Entity.Localidade;
            txtEndereco.Text = endereco.Entity.Logradouro;
            txtBairro.Text = endereco.Entity.Bairro;
            cbUf.Text = endereco.Entity.UF;
        }

        private void chkSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSenha.Checked)
                txtSenhaUser.UseSystemPasswordChar = false;
            else
                txtSenhaUser.UseSystemPasswordChar = true;
        }
    }
}
