namespace Thomas.Greg.Aplicacao.Entidades
{
    public class LogradouroModel : DataModel
    {
        public  string Logradouro { get; set; }

        public  int Cep { get; set; }

        public  int Numero { get; set; }

        public  string Complmento { get; set; }

        public  string Uf { get; set; }

        public  string Municipio { get; set; }

        public  string Bairro { get; set; }

        public  ClienteModel Cliente { get; set; }
    }
}
