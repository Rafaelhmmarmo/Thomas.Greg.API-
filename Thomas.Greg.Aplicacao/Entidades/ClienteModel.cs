using System;
using System.Collections.Generic;
using System.Text;

namespace Thomas.Greg.Aplicacao.Entidades
{
    public class ClienteModel : DataModel
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public List<LogradouroModel> Logradouro { get; set; }
    }
}
