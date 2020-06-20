using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Thomas.Greg.Aplicacao.Interfaces.API;
using Thomas.Greg.Aplicacao.Responses;

namespace Thomas.Greg.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteAplicacao _cliente;

        public ClienteController(IClienteAplicacao cliente) { _cliente = cliente; }

        [HttpGet("id:int")]
        public ActionResult<ClienteResponse> ObterPorId(int Id)
        {
            return Ok(_cliente.ObterPorId(Id));
        }

        [HttpDelete]
        public ActionResult<bool> ExcluirPorId(int Id)
        {
            return Ok(_cliente.ExcluirPorId(Id));
        }

        [HttpPost]
        public ActionResult<bool> Gravar([FromBody]ClienteResponse request)
        {
            return Ok(_cliente.Gravar(request));
        }

        [HttpPut]
        public ActionResult<bool> Update([FromBody]ClienteResponse request)
        {
            return Ok(_cliente.Update(request));
        }

        [HttpGet]
        public ActionResult<List<ClienteResponse>> RetornaTodos()
        {
            return _cliente.RetornaTodos();
        }
    }
}
