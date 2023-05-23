using Desktop_Biblioteca.Client;
using Desktop_Biblioteca.Client.Models;
using Desktop_Biblioteca.DAO.Cliente;
using Desktop_Biblioteca.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Desktop_Biblioteca.Cadastro.Cliente
{
    public partial class FrmCadastroCliente : Form
    {
        public FrmCadastroCliente()
        {
            InitializeComponent();
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
                var endereco = new Endereco(cbUf.SelectedItem.ToString(), txtCidade.Text, txtBairro.Text, txtEndereco.Text, txtNumero.Text, txtComplemento.Text);
                var cliente = new Entidades.Cliente(txtNome.Text, dtDataNascimento.Value, txtRg.Text, txtEmail.Text, txtTelefone.Text, endereco);

                var clienteDao = new ClienteDao();
                clienteDao.Insert(cliente);

                lblSucesso.Visible = true;
                btnLimpar_Click(sender, e);
            }
            catch (Exception)
            {
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
    }
}
