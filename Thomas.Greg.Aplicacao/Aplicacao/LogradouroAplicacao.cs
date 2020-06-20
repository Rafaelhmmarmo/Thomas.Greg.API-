using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Thomas.Greg.Aplicacao.Entidades;
using Thomas.Greg.Aplicacao.Interfaces.API;
using Thomas.Greg.Aplicacao.Interfaces.Repository;
using Thomas.Greg.Aplicacao.Responses;

namespace Thomas.Greg.Aplicacao.Aplicacao
{
    public class LogradouroAplicacao : ILogradouroAplicacao
    {
        private readonly ILogradouroRepository _logradouro;
        private readonly IMapper _mapper;

        public LogradouroAplicacao(ILogradouroRepository logradouro, IMapper mapper)
        { _logradouro = logradouro; _mapper = mapper; }

        public LogradouroResponse ObterPorId(int id)
        {
            var logradouro = _logradouro.RetornarPorId(id);

            return _mapper.Map<LogradouroResponse>(logradouro);
        }

        public bool ExcluirPorId(int id)
        {
            return _logradouro.ExcluirPorId(id);
        }

        public bool Gravar(LogradouroResponse request)
        {
            return _logradouro.Gravar(_mapper.Map<LogradouroModel>(request));
        }

        public bool Update(LogradouroResponse request)
        {
            return _logradouro.Update(_mapper.Map<LogradouroModel>(request));
        }

        public List<LogradouroResponse> RetornaTodos()
        {
            var logradouro = _logradouro.RetornaTodos();

            return _mapper.Map<List<LogradouroResponse>>(logradouro);
        }
    }
}
