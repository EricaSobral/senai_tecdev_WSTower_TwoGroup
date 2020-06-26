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
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private IUsuarioRepository _usuarioRepository { get; set; }

        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }


        //[HttpPost]
        //public IActionResult Post(LoginViewModel login)
        //{
        //    try
        //    {
        //        Usuario usuarioBuscado = _usuarioRepository.Login(login.Email, login.Apelido, login.Senha);

        //        if (usuarioBuscado == null)
        //        {
        //            return NotFound("E-mail ou senha inválidos!");
        //        }


        //    }
        //    catch (Exception error)
        //    {
        //        return BadRequest(new
        //        {
        //            mensagem = "Não foi possível gerar o token",
        //            error
        //        });
        //    }
        //    return Ok(new
        //    {
        //        mensagem = "Usuario Logado!",
        //    });
        //}
    }
}
