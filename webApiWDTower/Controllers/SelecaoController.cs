using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApiWDTower.Interfaces;
using webApiWDTower.Repositories;

namespace webApiWDTower.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class SelecaoController : ControllerBase
    {
        private ISelecaoRepository _selecaoRepository { get; set; }

        public SelecaoController()
        {
            _selecaoRepository = new SelecaoRepository();

        }
        /// <summary>
        /// funcionando
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_selecaoRepository.ListarSelecao());

        }
    }
}
