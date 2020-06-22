using AutoMapper;
using NHibernate;
using System.Collections.Generic;
using System.Linq;
using Thomas.Greg.Aplicacao.Entidades;
using Thomas.Greg.Aplicacao.Interfaces.Repository;
using Thomas.Greg.Data.NHibernateData.Conexao;
using Thomas.Greg.Data.NHibernateData.Data;

namespace Thomas.Greg.Data.NHibernateData.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IMapper _mapper;

        public ClienteRepository(IMapper mapper) { _mapper = mapper; }
       
        public IList<ClienteModel> RetornaTodos()
        {
            var session = NHibernateConexao.GetSessionLocal();
            var resultado = session.Query<ClienteData>().ToList();
            session.Close();
            return _mapper.Map<IList<ClienteModel>>(resultado);
        }

        public ClienteModel RetornarPorId(int id)
        {
            var session = NHibernateConexao.GetSessionLocal();

            var resultado = session
                .Query<ClienteData>()
                .Where(w => w.Id == id)
                .ToList();

            session.Close();

            return _mapper.Map<ClienteModel>(resultado.FirstOrDefault());
        }
      
        public bool ExcluirPorId(int id)
        {
            var session = NHibernateConexao.GetSessionLocal();
            var trans = session.BeginTransaction();

            try
            {
                session.Delete(session.Load<ClienteData>(id));
                trans.Commit();
                session.Close();
                return true;
            }
            catch
            {
                trans.Rollback();
                session.Close();
                return false;
            }
        }

        public bool Gravar(ClienteModel objeto)
        {
            
            var session = NHibernateConexao.GetSessionLocal();
            var trans = session.BeginTransaction();
            var cliente = _mapper.Map<ClienteData>(objeto);

            if (!VerificaEmail(cliente.Email, session))
            {
                try
                {
                    session.Save(cliente);
                    trans.Commit();
                    session.Close();
                    return true;
                }
                catch
                {
                    trans.Rollback();
                    session.Close();
                    return false;
                }
            }
            return false;
        }

        public bool Update(ClienteModel objeto)
        {
            var session = NHibernateConexao.GetSessionLocal();
            var trans = session.BeginTransaction();
            var cliente = _mapper.Map<ClienteData>(objeto);

            try
            {
                session.Update(cliente);
                trans.Commit();
                session.Close();
                return true;
            }
            catch
            {
                trans.Rollback();
                session.Close();
                return false;
            }
        }       

        private bool VerificaEmail(string email, ISession session)
        {
            return session.Query<ClienteData>().Where(w => w.Email == email).Any();
        }
    }
}
