using System;
using System.Collections.Generic;
using System.Text;
using Thomas.Greg.Aplicacao.Entidades;

namespace Thomas.Greg.Aplicacao.Interfaces.Repository
{
    public interface ILogradouroRepository
    {
        LogradouroModel RetornarPorId(int id);
        bool ExcluirPorId(int id);
        bool Gravar(LogradouroModel objeto);
        bool Update(LogradouroModel objeto);
        IList<LogradouroModel> RetornaTodos();
    }
}
