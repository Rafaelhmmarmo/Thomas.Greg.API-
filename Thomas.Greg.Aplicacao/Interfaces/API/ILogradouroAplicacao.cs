using System;
using System.Collections.Generic;
using System.Text;
using Thomas.Greg.Aplicacao.Responses;

namespace Thomas.Greg.Aplicacao.Interfaces.API
{
    public interface ILogradouroAplicacao
    {
        LogradouroResponse ObterPorId(int id);
        bool ExcluirPorId(int id);
        bool Gravar(LogradouroResponse objeto);
        bool Update(LogradouroResponse objeto);
        List<LogradouroResponse> RetornaTodos();
    }
}
