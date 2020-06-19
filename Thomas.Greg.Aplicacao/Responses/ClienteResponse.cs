using System.Collections.Generic;

namespace Thomas.Greg.Aplicacao.Responses
{
    public class ClienteResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }

        public virtual List<LogradouroResponse> Logradouro { get; set; }
    }
}
