using System;
using System.Collections.Generic;

namespace Desktop_Biblioteca.Entidades
{
    public class Emprestimo : Base
    {
        public Emprestimo(int clienteId, int funcionarioId, DateTime dataMaxima)
        {
            ClienteId = clienteId;
            FuncionarioId = funcionarioId;
            DataEmprestimo = DateTime.Now;
            DataMaximaDevolucao = dataMaxima;
        }

        public int ClienteId { get; set; }
        public int FuncionarioId { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataMaximaDevolucao { get; set; }
        public List<EmprestimoLivro> LivrosEmprestados { get; set; } = new List<EmprestimoLivro>();
    }
}
