using System.Collections.Generic;

namespace Thomas.Greg.Data.NHibernateData.Data
{
    public class ClienteData : DataBase
    {
        public virtual string Nome { get; set; }

        public virtual string Email { get; set; }

        public virtual List<LogradouroData> Logradouro { get; set; }
    }
}
