namespace Desktop_Biblioteca.Entidades.Livro
{
    public class Autor
    {
        public Autor()
        {

        }
        public Autor(string nome)
        {
            Nome = nome;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
