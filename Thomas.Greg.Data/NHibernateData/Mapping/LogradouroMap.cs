using FluentNHibernate.Mapping;
using Thomas.Greg.Data.NHibernateData.Data;

namespace Thomas.Greg.Data.NHibernateData.Mapping
{
    public class LogradouroMap : ClassMap<LogradouroData>
    {
        public LogradouroMap()
        {
            Table("LOGRADOURO");

            Id(m => m.Id, "ID");
            Map(m => m.Logradouro, "LOGRADOURO");
            Map(m => m.Municipio, "MUNICIPIO");
            Map(m => m.Numero, "NUMERO");
            Map(m => m.Uf, "UF");
            Map(m => m.Cep, "CEP");
            Map(m => m.Bairro, "BAIRRO");
            Map(m => m.Complmento, "COMPLEMENTO");
            References(r => r.Cliente, "IdCliente");
        }
    }
}
