using System.Collections.Generic;
using Thomas.Greg.Aplicacao.Entidades;

namespace Thomas.Greg.Aplicacao.Interfaces.Repository
{
    public interface IClienteRepository
    {
        ClienteModel RetornarPorId(int id);
        bool ExcluirPorId(int id);
        bool Gravar(ClienteModel objeto);
        bool Update(ClienteModel objeto);
        IList<ClienteModel> RetornaTodos();
    }
}
