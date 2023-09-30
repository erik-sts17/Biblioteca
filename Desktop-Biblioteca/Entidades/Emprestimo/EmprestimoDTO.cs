using System;

namespace Desktop_Biblioteca.Entidades
{
    public class EmprestimoDTO
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string EmailCliente { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataEsperadaDevolucao { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public int TotalLivros { get; set; }
    }
}
