using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApiWDTower.Domains;
using webApiWDTower.Interfaces;
using webApiWDTower.Repositories;

namespace webApiWDTower.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class JogadorController : ControllerBase
    {
        private IJogadorRepository _jogadorRepository;

        public JogadorController()
        {
            _jogadorRepository = new JogadorRepository();

        }
        [HttpGet("{nome}")]
        public IActionResult BuscarPorNome(string nome)
        {
            try
            {

                Jogador jogadorBuscado = _jogadorRepository.BuscarPorNome(nome);


                if (jogadorBuscado != null)
                {
                    return Ok(jogadorBuscado);
                }

                return NotFound("Nenhum jogador com esse nome foi encontrado!");
            }
            catch (Exception error)
            {
                return BadRequest(error);
            }
        }
        [HttpGet("Selecao/{idSelecao}")]
        public IActionResult BuscarPorSelecao(int idSelecao)
        {
            
                return Ok(_jogadorRepository.ListarPorSelecao(idSelecao));

        }


    }
}
