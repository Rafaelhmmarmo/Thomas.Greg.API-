using FluentNHibernate.Mapping;
using Thomas.Greg.Data.NHibernateData.Data;

namespace Thomas.Greg.Data.NHibernateData.Mapping
{
    public class ClienteMap : ClassMap<ClienteData>
    {
        public ClienteMap()
        {
            Table("CLIENTE");

            Id(m => m.Id, "ID");
            Map(m => m.Nome, "NOME");
            Map(m => m.Email, "EMAIL");
            HasMany(m => m.Logradouro);
        }
    }
}
