using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi_twTower.Domains;
using WebApi_twTower.Repositories;

namespace WebApi_twTower.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class SelecaoController : ControllerBase
    {
        SelecaoRepository selecao = new SelecaoRepository();

        [HttpGet]
        public IActionResult listSelecao()
        {
            return Ok(selecao.ListarSelecao());
        }
    }
}
