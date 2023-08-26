namespace Desktop_Biblioteca.Entidades.Livro
{
    public class Genero : Base
    {
        public Genero()
        {

        }
        public Genero(string descricao)
        {
            Descricao = descricao;
        }

        public string Descricao { get; set; }

        public override string ToString()
        {
            return Descricao;
        }
    }
}
