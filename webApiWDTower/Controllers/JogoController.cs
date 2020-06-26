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
    public class JogoController : ControllerBase
    {
        private IJogoRepository _jogoRepository;

        public JogoController()
        {
            _jogoRepository = new JogoRepository();

        }
        /// <summary>
        /// bugado
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_jogoRepository.ListarJogos());
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        /// <summary>
        /// funcionando
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpGet("BuscarDataJogo/{data}")]
        public IActionResult GetByDate(DateTime data)
        {
            return Ok(_jogoRepository.ListarDataJogo(data));
        }
        /// <summary>
        /// funcionando
        /// </summary>
        /// <param name="estadio"></param>
        /// <returns></returns>
        [HttpGet("BuscarPorEstadio/{estadio}")]
        public IActionResult GetByStadium(string estadio)
        {
            return Ok(_jogoRepository.ListarEstadioJogo(estadio));
        }
        /// <summary>
        /// bugado
        /// </summary>
        /// <param name="selecao"></param>
        /// <returns></returns>
        [HttpGet("BuscarPorSelecao/{selecao}")]
        public IActionResult GetByTeam(string selecao)
        {
            return Ok(_jogoRepository.ListarSelecaoJogo(selecao));
        }
     

    }
}
