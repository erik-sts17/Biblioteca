using System.Collections.Generic;

namespace Desktop_Biblioteca.Entidades.Livro
{
    public class Livro : Base
    {
        public Livro()
        {

        }
        public Livro(string titulo, int categoriaId, int generoId, int paginas, byte[] imagem, int quantidadeEstoque)
        {
            Titulo = titulo;
            CategoriaId = categoriaId;
            GeneroId = generoId;
            Paginas = paginas;
            Imagem = imagem;
            QuantidadeEstoque = quantidadeEstoque;
        }
        public string Titulo { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int GeneroId { get; set; }
        public Genero Genero { get; set; }
        public List<int> AutoresId { get; set; }
        public int Paginas { get; set; }
        public byte[] Imagem { get; set; }
        public int QuantidadeEstoque { get; set; }

        public override string ToString()
        {
            return Titulo;
        }
    }
}
