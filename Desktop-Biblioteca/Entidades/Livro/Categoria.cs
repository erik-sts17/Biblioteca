namespace Desktop_Biblioteca.Entidades.Livro
{
    public class Categoria : Base
    {
        public Categoria()
        {

        }
        public Categoria(string descricao)
        {
            Descricao = descricao;
        }

        public Categoria(string descricao, int id)
        {
            Descricao = descricao;
            Id = id;
        }


        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
