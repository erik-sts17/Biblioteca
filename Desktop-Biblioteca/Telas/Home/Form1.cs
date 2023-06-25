using Desktop_Biblioteca.Cadastro;
using Desktop_Biblioteca.Cadastro.Autor;
using Desktop_Biblioteca.Cadastro.Cliente;
using Desktop_Biblioteca.Cadastro.Genero;
using Desktop_Biblioteca.Consulta;
using Desktop_Biblioteca.Livro.Categoria;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Desktop_Biblioteca.Home
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            if (submenuCliente.Visible)
                submenuCliente.Visible = false;
            else
                submenuCliente.Visible = true;
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            if (submenuLivro.Visible)
            {
                submenuLivro.Visible = false;
                subMenuLivroCadastro.Visible = false;
                subMenuLivroConsulta.Visible = false;
                btnLivroCadastro.BackColor = Color.FromArgb(37, 46, 59);
                btnLivroConsulta.BackColor = Color.FromArgb(37, 46, 59);
            }
            else
                submenuLivro.Visible = true;
        }

        private void btnConsultarFuncionario_Click(object sender, EventArgs e)
        {
  
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente cadastroCliente = new FrmCadastroCliente();
            cadastroCliente.Show();
        }

        private void btnLivroCadastro_Click(object sender, EventArgs e)
        {
            subMenuLivroConsulta.Visible = false;
            btnLivroConsulta.BackColor = Color.FromArgb(37, 46, 59);
            if (subMenuLivroCadastro.Visible)
            {
                subMenuLivroCadastro.BringToFront();
                subMenuLivroCadastro.Visible = false;
                btnLivroCadastro.BackColor = Color.FromArgb(37, 46, 59);
            }
            else
            {
                subMenuLivroCadastro.BringToFront();
                subMenuLivroCadastro.Visible = true;
                btnLivroCadastro.BackColor = Color.FromArgb(255, 194, 0);
            }
        }

       
        private void btnLivroConsulta_Click(object sender, EventArgs e)
        {
            subMenuLivroCadastro.Visible = false;
            btnLivroCadastro.BackColor = Color.FromArgb(37, 46, 59);
            if (subMenuLivroConsulta.Visible)
            {
                subMenuLivroConsulta.BringToFront();
                subMenuLivroConsulta.Visible = false;
                btnLivroConsulta.BackColor = Color.FromArgb(37, 46, 59);
            }
            else
            {
                subMenuLivroConsulta.BringToFront();
                subMenuLivroConsulta.Visible = true;
                btnLivroConsulta.BackColor = Color.FromArgb(255, 194, 0);
            }
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                Application.OpenForms[i].Hide();
            }
        }

        private void btnCadastroLivro_Click(object sender, EventArgs e)
        {
            FrmCadastroLivro frmCadastroLivro = new FrmCadastroLivro();
            frmCadastroLivro.Show();
        }

        private void btnCadastroAutor_Click(object sender, EventArgs e)
        {
            FrmCadastroAutor frmCadastroAutor = new FrmCadastroAutor();
            frmCadastroAutor.Show();
        }

        private void btnCadastroGenero_Click(object sender, EventArgs e)
        {
            FrmCadastroGenero frmCadastroGenero = new FrmCadastroGenero();
            frmCadastroGenero.Show();
        }

        private void timerDataHora_Tick(object sender, EventArgs e)
        {
            var data = DateTime.Now;
            lblDataAtual.Text = data.ToLongDateString() + " " + data.ToLongTimeString();
        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            if (subMenuEmprestimo.Visible)
                subMenuEmprestimo.Visible = false;
            else
                subMenuEmprestimo.Visible = true;
        }

        private void btnCadastroCategoria_Click(object sender, EventArgs e)
        {
            FrmCadastroCategoria frmCadastroCategoria = new FrmCadastroCategoria();
            frmCadastroCategoria.Show();
        }

        private void btnConsultaAutor_Click(object sender, EventArgs e)
        {
            FrmConsultaAutor frmConsultaAutor = new FrmConsultaAutor();
            frmConsultaAutor.Show();
        }

        private void btnConsultaCategoria_Click_1(object sender, EventArgs e)
        {
            FrmConsultaCategoria frmConsultaCategoria = new FrmConsultaCategoria();
            frmConsultaCategoria.Show();
        }

        private void btnConsultaGenero_Click(object sender, EventArgs e)
        {
            FrmConsultaGenero frmConsultaGenero = new FrmConsultaGenero();
            frmConsultaGenero.Show();
        }

        private void btnCadstroFuncionario_Click(object sender, EventArgs e)
        {
            FrmCadastroFuncionario frmCadastroFuncionario = new FrmCadastroFuncionario();
            frmCadastroFuncionario.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            if (subMenuFuncionario.Visible)
                subMenuFuncionario.Visible = false;
            else
                subMenuFuncionario.Visible = true;
        }
    }
}
