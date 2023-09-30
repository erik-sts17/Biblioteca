namespace Desktop_Biblioteca.Entidades
{
    public class Endereco : Base
    {
        public Endereco(string cep, string uf, string cidade, string bairro, string logradouro, string numero, string complemento)
        {
            Cep = cep;
            Uf = uf;
            Cidade = cidade;
            Bairro = bairro;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
        }

        public Endereco()
        {
            
        }
        public string Cep { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
    }
}
