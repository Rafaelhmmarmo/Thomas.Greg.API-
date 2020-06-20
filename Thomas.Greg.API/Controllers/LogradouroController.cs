using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Thomas.Greg.Aplicacao.Interfaces.API;
using Thomas.Greg.Aplicacao.Responses;

namespace Thomas.Greg.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogradouroController : ControllerBase
    {
        private readonly ILogradouroAplicacao _logradouro;

        public LogradouroController(ILogradouroAplicacao logradouro) { _logradouro = logradouro; }

        [HttpGet("id:int")]
        public ActionResult<LogradouroResponse> ObterPorId(int Id)
        {
            return Ok(_logradouro.ObterPorId(Id));
        }

        [HttpDelete]
        public ActionResult<bool> ExcluirPorId(int Id)
        {
            return Ok(_logradouro.ExcluirPorId(Id));
        }

        [HttpPost]
        public ActionResult<bool> Gravar([FromBody]LogradouroResponse request)
        {
            return Ok(_logradouro.Gravar(request));
        }

        [HttpPut]
        public ActionResult<bool> Update([FromBody]LogradouroResponse request)
        {
            return Ok(_logradouro.Update(request));
        }

        [HttpGet]
        public ActionResult<List<LogradouroResponse>> RetornaTodos()
        {
            return _logradouro.RetornaTodos();
        }
    }
}
