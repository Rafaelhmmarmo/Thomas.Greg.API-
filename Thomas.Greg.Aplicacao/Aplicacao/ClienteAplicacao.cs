using AutoMapper;
using NHibernate.Mapping;
using System.Collections.Generic;
using System.Net.Http.Headers;
using Thomas.Greg.Aplicacao.Entidades;
using Thomas.Greg.Aplicacao.Interfaces.API;
using Thomas.Greg.Aplicacao.Interfaces.Repository;
using Thomas.Greg.Aplicacao.Responses;

namespace Thomas.Greg.Aplicacao.Aplicacao
{
    public class ClienteAplicacao : IClienteAplicacao
    {
        private readonly IClienteRepository _cliente;
        private readonly IMapper _mapper;

        public ClienteAplicacao(IClienteRepository cliente, IMapper mapper)
        { _cliente = cliente; _mapper = mapper; }

        public ClienteResponse ObterPorId(int id)
        {
            var cliente = _cliente.RetornarPorId(id);

            return _mapper.Map<ClienteResponse>(cliente);
        }

        public bool ExcluirPorId(int id)
        {
            return _cliente.ExcluirPorId(id);
        }

        public bool Gravar(ClienteResponse request)
        {
            return _cliente.Gravar(_mapper.Map<ClienteModel>(request));
        }

        public bool Update(ClienteResponse request)
        {
            return _cliente.Update(_mapper.Map<ClienteModel>(request));
        }

        public List<ClienteResponse> RetornaTodos()
        {
            var cliente = _cliente.RetornaTodos();

            return _mapper.Map<List<ClienteResponse>>(cliente);
        }
    }
}
