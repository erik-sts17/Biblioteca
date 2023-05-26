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
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
