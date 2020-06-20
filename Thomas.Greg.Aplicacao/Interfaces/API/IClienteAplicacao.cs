using System.Collections.Generic;
using Thomas.Greg.Aplicacao.Responses;

namespace Thomas.Greg.Aplicacao.Interfaces.API
{
    public interface IClienteAplicacao
    {
        ClienteResponse ObterPorId(int id);
        bool ExcluirPorId(int id);
        bool Gravar(ClienteResponse objeto);
        bool Update(ClienteResponse objeto);
        List<ClienteResponse> RetornaTodos();
    }
}
