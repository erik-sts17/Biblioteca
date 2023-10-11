using Desktop_Biblioteca.Entidades.Funcionarios;
using System;

namespace Desktop_Biblioteca.Entidades
{
    public class Funcionario : Base
    {
        public Funcionario()
        {
            
        }
        public Funcionario(string nome, DateTime dataNascimento, string rg, string cpf, string email, string telefone, Endereco endereco, Login login, NivelAcesso nivelAcesso, Genero genero)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Rg = rg;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            Login = login;
            NivelAcesso = nivelAcesso;
            Genero = genero;
        }

        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Rg { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public Endereco Endereco { get; set; }
        public Login Login { get; set; }
        public NivelAcesso NivelAcesso { get; set; }
        public Genero Genero { get; set; }
    }
}
