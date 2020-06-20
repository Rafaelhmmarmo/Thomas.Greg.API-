using AutoMapper;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using Thomas.Greg.Aplicacao.Entidades;
using Thomas.Greg.Aplicacao.Interfaces.Repository;
using Thomas.Greg.Data.NHibernateData.Conexao;
using Thomas.Greg.Data.NHibernateData.Data;

namespace Thomas.Greg.Data.NHibernateData.Repository
{
    public class LogradouroRepository : ILogradouroRepository
    {
        private readonly IMapper _mapper;

        public LogradouroRepository(IMapper mapper) { _mapper = mapper; }

        public IList<LogradouroModel> RetornaTodos()
        {
            var session = NHibernateConexao.GetSessionLocal();
            var resultado = session.Query<LogradouroData>().ToList();
            session.Close();
            return _mapper.Map<List<LogradouroModel>>(resultado);
        }

        public LogradouroModel RetornarPorId(int id)
        {
            var session = NHibernateConexao.GetSessionLocal();

            var resultado = session
                .Query<LogradouroData>()
                .Where(w => w.Id == id)
                .ToList();

            session.Close();
            return _mapper.Map<LogradouroModel>(resultado.FirstOrDefault());
        }

        public bool ExcluirPorId(int id)
        {
            var session = NHibernateConexao.GetSessionLocal();
            var objeto = RetornarPorId(id, session);
            var trans = session.BeginTransaction();

            try
            {
                session.Delete(session.Load<LogradouroData>(id));
                trans.Commit();
                session.Close();
                return true;
            }
            catch (Exception ex)
            {
                trans.Rollback();
                session.Close();
                return false;
            }
        }

        public bool Gravar(LogradouroModel objeto)
        {
            NHibernateConexao.GeraSchema();

            var session = NHibernateConexao.GetSessionLocal();
            var trans = session.BeginTransaction();
            var logradouro = _mapper.Map<LogradouroData>(objeto);
   
                try
                {
                    session.Save(logradouro);
                    trans.Commit();
                    session.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    session.Close();
                    return false;
                }

        }

        public bool Update(LogradouroModel objeto)
        {
            var session = NHibernateConexao.GetSessionLocal();
            var trans = session.BeginTransaction();
            var logradouro = _mapper.Map<LogradouroData>(objeto);

            try
            {
                session.Update(logradouro);
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
        private LogradouroModel RetornarPorId(int id, ISession session)
        {
            var resultado = session
                .Query<LogradouroData>()
                .Where(w => w.Id == id)
                .ToList();

            return _mapper.Map<LogradouroModel>(resultado.FirstOrDefault());
        }
        
    }
}
