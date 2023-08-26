using System;

namespace Desktop_Biblioteca.Entidades
{
    public class Cliente : Base
    {
        public Cliente()
        {
            
        }
        public Cliente(string nome, DateTime dataNascimento, string rg, string email, string telefone, Endereco endereco)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Rg = rg;    
            Email = email;  
            Telefone = telefone;
            Endereco = endereco;
        }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Rg { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
    }
}
