namespace Desktop_Biblioteca.Entidades.Livro
{
    public class Livro
    {
        public Livro()
        {

        }
        public Livro(string titulo, int categoriaId, int generoId, int autorId, int paginas)
        {
            Titulo = titulo;
            CategoriaId = categoriaId;
            GeneroId = generoId;    
            AutorId = autorId;  
            Paginas = paginas;
        }

        public int Id { get; set;}
        public string Titulo { get; set; }
        public int CategoriaId { get; set; }
        public int GeneroId { get; set; }
        public int AutorId { get; set; }
        public int Paginas { get; set; }
    }
}
