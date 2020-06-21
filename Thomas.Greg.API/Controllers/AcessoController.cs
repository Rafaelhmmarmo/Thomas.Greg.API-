using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Thomas.Greg.Aplicacao.Interfaces.API;

namespace Thomas.Greg.API.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("[controller]")]
    public class AcessoController : ControllerBase
    {
        private readonly IAcessoAplicacao _acesso;

        public AcessoController(IAcessoAplicacao acesso) { _acesso = acesso; }

        [HttpGet("ObterToken")]
        public ActionResult<string> ObterToken()
        {
            var token = _acesso.GerarToken();

            return Ok(token);
        }
    }
}
