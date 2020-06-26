using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApiWDTower.Domains;
using webApiWDTower.Interfaces;
using webApiWDTower.Repositories;
using webApiWDTower.ViewModels;

namespace webApiWDTower.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                
                return Ok(_usuarioRepository.Listar());
            }
            catch (Exception error)
            {
                
                return BadRequest(error);
            }
        }
        [HttpPost]
        public IActionResult Post(Usuario novoUsuario)
        {
            try
            {
                _usuarioRepository.Cadastrar(novoUsuario);

                return StatusCode(201);
            }
            catch (Exception error)
            {
                return BadRequest(error);
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                
                Usuario usuarioBuscado = _usuarioRepository.BuscarPorId(id);

                
                if (usuarioBuscado != null)
                {
                    return Ok(usuarioBuscado);
                }

                return NotFound("Nenhum usuário encontrado para o ID informado");
            }
            catch (Exception error)
            {
                return BadRequest(error);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Usuario usuarioAtualizado)
        {
            try
            {
                Usuario usuarioBuscado = _usuarioRepository.BuscarPorId(id);

                if (usuarioBuscado != null)
                {
                    _usuarioRepository.Atualizar(id, usuarioAtualizado);

                    return StatusCode(204);
                }

                return NotFound("Nenhum usuário encontrado para o ID informado");
            }
            catch (Exception error)
            {

                return BadRequest(error);
            }
        }
        [HttpPut("Senha/{id}")]
        public IActionResult PutSenha(int id, Usuario usuarioNovaSenha)
        {
            try
            {
                Usuario usuarioBuscado = _usuarioRepository.BuscarPorId(id);

                if (usuarioBuscado != null)
                {
                    _usuarioRepository.Atualizar(id, usuarioNovaSenha);

                    return StatusCode(204);
                }

                return NotFound("Nenhum usuário encontrado para o ID informado");
            }
            catch (Exception error)
            {

                return BadRequest(error);
            }
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                Usuario usuarioBuscado = _usuarioRepository.BuscarPorId(id);

                if (usuarioBuscado != null)
                {
                    _usuarioRepository.Deletar(id);

                    return StatusCode(202);
                }

                return NotFound("Nenhum usuário encontrado com o Id infomado!!");
            }
            catch (Exception error)
            {
                return BadRequest(error);
            }
        }
        //[HttpPost("Login")]
        //public IActionResult Login(LoginViewModel login, string email, string apelido, string senha)
        //{
        //    Usuario usuarioBuscado = _usuarioRepository.Login(login.Email, login.Apelido, login.Senha);

        //    if(usuarioBuscado == null)
        //    {
        //        return BadRequest("Usuário ou senha inválidos!");
        //    }
        //    return Ok("Usuário logado!");
              
        //}

    }
}
