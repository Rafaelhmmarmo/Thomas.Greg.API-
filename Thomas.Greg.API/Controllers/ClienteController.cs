using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Thomas.Greg.Aplicacao.Interfaces.API;
using Thomas.Greg.Aplicacao.Responses;

namespace Thomas.Greg.API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteAplicacao _cliente;

        public ClienteController(IClienteAplicacao cliente) { _cliente = cliente; }

        [HttpGet("ObterPorId")]
        public ActionResult<ClienteResponse> ObterPorId(int Id)
        {
            var cliente = _cliente.ObterPorId(Id);

            return Ok(cliente);
        }

        [HttpDelete("ExcluirPorId")]
        public ActionResult<bool> ExcluirPorId(int Id)
        {
            return Ok(_cliente.ExcluirPorId(Id));
        }

        [HttpPost("Gravar")]
        public ActionResult<bool> Gravar([FromBody]ClienteResponse request)
        {
            return Ok(_cliente.Gravar(request));
        }

        [HttpPut("Atualizar")]
        public ActionResult<bool> Update([FromBody]ClienteResponse request)
        {
            return Ok(_cliente.Update(request));
        }

        [HttpGet("RetornaTodos")]
        public ActionResult<List<ClienteResponse>> RetornaTodos()
        {
            return _cliente.RetornaTodos();
        }
    }
}
