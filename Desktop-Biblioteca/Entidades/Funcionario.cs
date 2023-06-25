using System;

namespace Desktop_Biblioteca.Entidades
{
    public class Funcionario : Base
    {
        public Funcionario(string nome, DateTime dataNascimento, string rg, string cpf, string email, string telefone, Endereco endereco, Login login)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Rg = rg;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            Login = login;
        }

        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public Login Login { get; set; }
    }
}
