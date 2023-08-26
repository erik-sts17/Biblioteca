namespace Desktop_Biblioteca.Entidades
{
    public class EmprestimoLivro
    {
        public int LivroId { get; set; }
        public Livro.Livro Livro { get; set; }
        public int EmprestimoId { get; set; }
        public Emprestimo Emprestimo { get; set; }
    }
}
