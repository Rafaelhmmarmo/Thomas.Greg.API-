namespace Thomas.Greg.Aplicacao.Entidades
{
    public class LogradouroModel : DataModel
    {
        public virtual string Logradouro { get; set; }

        public virtual int Cep { get; set; }

        public virtual int Numero { get; set; }

        public virtual string Complmento { get; set; }

        public virtual string Uf { get; set; }

        public virtual string Municipio { get; set; }

        public virtual string Bairro { get; set; }

        public virtual ClienteModel Cliente { get; set; }
    }
}
