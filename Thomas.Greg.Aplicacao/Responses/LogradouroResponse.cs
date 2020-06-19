namespace Thomas.Greg.Aplicacao.Responses
{
    public class LogradouroResponse
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }

        public int Cep { get; set; }

        public int Numero { get; set; }

        public string Complmento { get; set; }

        public string Uf { get; set; }

        public string Municipio { get; set; }

        public string Bairro { get; set; }

        public ClienteResponse Cliente { get; set; }
    }
}
