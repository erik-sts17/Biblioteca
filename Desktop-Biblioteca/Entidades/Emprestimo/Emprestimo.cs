using System;
using System.Collections.Generic;

namespace Desktop_Biblioteca.Entidades
{
    public class Emprestimo : Base
    {
        public Emprestimo(int clienteId, DateTime dataMaxima)
        {
            ClienteId = clienteId;
            DataEmprestimo = DateTime.Now;
            DataMaximaDevolucao = dataMaxima;
        }

        public int ClienteId { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataMaximaDevolucao { get; set; }
        public List<EmprestimoLivro> LivrosEmprestados { get; set; } = new List<EmprestimoLivro>();
    }
}
