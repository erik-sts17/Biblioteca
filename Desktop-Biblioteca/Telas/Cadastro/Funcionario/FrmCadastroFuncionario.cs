using Desktop_Biblioteca.Client;
using Desktop_Biblioteca.Client.Models;
using Desktop_Biblioteca.DAO.Cliente;
using Desktop_Biblioteca.DAO.Funcionario;
using Desktop_Biblioteca.Entidades;
using MySql.Data.MySqlClient.Memcached;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Desktop_Biblioteca.Cadastro.Cliente
{
    public partial class FrmCadastroFuncionario : Form
    {
        public bool Edicao { get; set; }
        public FrmCadastroFuncionario(Entidades.Funcionario funcionario = null)
        {
            InitializeComponent();
            if (funcionario != null)
            {
                lblCadastroFuncionario.Text = "Edição de Funcionário";
                btnSalvar.Text = "Editar";
                btnSalvar.BackColor = Color.Yellow;
                btnSalvar.ForeColor = Color.Black;
                lblSucesso.ForeColor = Color.Yellow;
                lblSucesso.Text = "Dados alterados com sucesso!";
                txtNome.Text = funcionario.Nome;
                txtEmail.Text = funcionario.Email;
                TxtCpf.Text = funcionario.Cpf;  
                txtRg.Text = funcionario.Rg;
                txtTelefone.Text = funcionario.Telefone;
                txtEndereco.Text = funcionario.Endereco.Logradouro;
                dtDataNascimento.Value = funcionario.DataNascimento;
                txtBairro.Text = funcionario.Endereco.Bairro;
                txtComplemento.Text = funcionario.Endereco.Complemento;
                txtNumero.Text = funcionario.Endereco.Numero;
                cbUf.Text = funcionario.Endereco.Uf;
                txtCep.Text = funcionario.Endereco.Cep;
                txtCidade.Text = funcionario.Endereco.Cidade;
                Edicao = true;
                enderecoId.Text = funcionario.Endereco.Id.ToString();
                clienteId.Text = funcionario.Id.ToString();
                groupLogin.Visible = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            TxtCpf.Clear();
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
            if (ValidaForm())
                return;

            try
            {
                var endereco = new Endereco(txtCep.Text, cbUf.SelectedItem.ToString(), txtCidade.Text, txtBairro.Text, txtEndereco.Text, txtNumero.Text, txtComplemento.Text);
                var login = new Entidades.Login(txtEmail.Text, txtSenhaUser.Text);
                var funcionario = new Funcionario(txtNome.Text, dtDataNascimento.Value, txtRg.Text,TxtCpf.Text, txtEmail.Text, txtTelefone.Text, endereco, login);
                var funcionarioDAO = new FuncionarioDAO();
                if (Edicao)
                {
                    funcionario.Id = int.Parse(clienteId.Text);
                    funcionario.Endereco.Id = int.Parse(enderecoId.Text);
                    funcionarioDAO.Atualizar(funcionario);
                }
                else 
                {
                    funcionarioDAO.Insert(funcionario, login);
                    btnLimpar_Click(sender, e);
                }
                lblSucesso.Visible = true;
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
            string[] textForms = new string[] { txtNome.Text, txtEmail.Text, txtRg.Text, txtTelefone.Text, txtCep.Text, txtCidade.Text, txtBairro.Text, txtEndereco.Text, txtNumero.Text };

            if (textForms.Any(x => String.IsNullOrEmpty(x)))
                erros.Add("Campos com '*' são obrigatórios!");

            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                erros.Add("Email inválido!");

            var idade = DateTime.Now.Year - dtDataNascimento.Value.Year;
            if (idade < 18)
                erros.Add("Cadastro permitido apenas para maiores de 18 anos!");

            if (!Edicao && !string.IsNullOrEmpty(txtSenhaUser.Text))
            {
                if (txtSenhaUser.Text.Length < 8)
                    erros.Add("Senha precisa ter no mínimo 8 caracteres!");
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                var clienteDao = new ClienteDao();
                var funcionarioDao = new FuncionarioDAO();
                if (clienteDao.ExisteCliente(txtEmail.Text) || funcionarioDao.ExisteFuncionario(txtEmail.Text))
                {
                    erros.Add($"Email {txtEmail.Text} já cadastrado.");
                }
            }

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
