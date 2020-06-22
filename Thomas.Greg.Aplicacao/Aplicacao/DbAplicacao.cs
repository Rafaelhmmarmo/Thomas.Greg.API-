using Thomas.Greg.Aplicacao.Interfaces.API;
using Thomas.Greg.Aplicacao.Interfaces.Repository;

namespace Thomas.Greg.Aplicacao.Aplicacao
{
    public class DbAplicacao : IDbAplicacao
    {
        private readonly IDbRepository _db;

        public DbAplicacao(IDbRepository db)
        {
            _db = db;
        }

        public bool GeraSchema()
        {
            return _db.GeraSchema();
        }


    }
}
