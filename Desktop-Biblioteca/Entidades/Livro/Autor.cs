namespace Desktop_Biblioteca.Entidades.Livro
{
    public class Autor : Base
    {
        public Autor()
        {

        }
        public Autor(string nome)
        {
            Nome = nome;
        }

        public Autor(string nome, int id)
        {
            Id = id;
            Nome = nome;
        }
        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
