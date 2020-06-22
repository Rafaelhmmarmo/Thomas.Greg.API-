using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Thomas.Greg.Aplicacao.Interfaces.API;

namespace Thomas.Greg.API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class DbController : ControllerBase
    {
        private readonly IDbAplicacao _db;

        public DbController(IDbAplicacao db) { _db = db; }

        [HttpGet("Gerar-Tabelas")]
        public ActionResult<bool> ExcluirPorId()
        {
            return Ok(_db.GeraSchema());
        }
    }
}
