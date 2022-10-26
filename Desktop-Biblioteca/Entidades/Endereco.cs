namespace Desktop_Biblioteca.Entidades
{
    public class Endereco
    {
        public Endereco(string uf, string cidade, string bairro, string logradouro, string numero, string complemento)
        {
            Uf = uf;
            Cidade = cidade;
            Bairro = bairro;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
        }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
    }
}
