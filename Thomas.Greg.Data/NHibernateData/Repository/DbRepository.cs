using Thomas.Greg.Aplicacao.Interfaces.Repository;
using Thomas.Greg.Data.NHibernateData.Conexao;

namespace Thomas.Greg.Data.NHibernateData.Repository
{
    public class DbRepository : IDbRepository
    {
        public bool GeraSchema()
        {
            try
            {
                NHibernateConexao.GeraSchema();
                return true;
            }
            catch
            {
                return false;
            }
        }
            
    }
}
