
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

        [HttpPost]
        public IActionResult LoginViewModel(LoginViewModel login)
        {

            string uValidar = _usuarioRepository.Logar(login);

            if (uValidar == "EmailApelido")
                return NotFound("Usuário não foi encontrado.");



            if (uValidar == "Senha")
                return NotFound("Senha inválida");


            if (uValidar == "Ok")
                return Ok("Dados Corretos - Efetuando Login");


            return NotFound("Erro");
        }
    }

}

