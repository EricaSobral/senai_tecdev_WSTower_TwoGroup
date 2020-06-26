using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webApiWDTower.Contexts;
using webApiWDTower.Domains;
using webApiWDTower.Interfaces;
using webApiWDTower.ViewModels;

namespace webApiWDTower.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        WebApiBDContext ctx = new WebApiBDContext();
        public void Atualizar(int id, Usuario usuarioAtualizado)
        {
            Usuario usuarioBuscado = ctx.Usuario.Find(id);

            if (usuarioBuscado != null)
            {
        
                if (usuarioAtualizado.Nome != null)
                {
                    usuarioBuscado.Nome = usuarioAtualizado.Nome;
                }

                if (usuarioAtualizado.Email != null)
                {
                    usuarioBuscado.Email = usuarioAtualizado.Email;
                }

                if (usuarioAtualizado.Apelido != null)
                {
                    usuarioBuscado.Apelido = usuarioAtualizado.Apelido;
                }

                //if (usuarioAtualizado.Foto != null)
                //{
                //    // Atribui o novo valor ao campo
                //    usuarioBuscado.Foto = usuarioAtualizado.Foto;
                //}

                ctx.Usuario.Update(usuarioBuscado);

                ctx.SaveChanges();
            }

        }

        public void AtualizarSenha(int id, Usuario usuarioNovaSenha)
        {
            Usuario usuarioBuscado = ctx.Usuario.Find(id);

            if (usuarioBuscado != null)
            {
                if (usuarioNovaSenha.Senha != null)
                {
                    usuarioBuscado.Senha = usuarioNovaSenha.Senha;
                }

                ctx.Usuario.Update(usuarioBuscado);

                ctx.SaveChanges();
            }

            
        }

        public Usuario BuscarPorId(int id)
        {
            Usuario usuarioBuscado = ctx.Usuario.FirstOrDefault(u => u.Id == id);

            if (usuarioBuscado != null)
            {
                return usuarioBuscado;
            }

            return null;
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            
            ctx.Usuario.Add(novoUsuario);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Usuario.Remove(BuscarPorId(id));
            ctx.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return ctx.Usuario.ToList();
        }

       
        string IUsuarioRepository.Logar(LoginViewModel loginViewModel)
        {
            string usuarioDados = "Ok";

            using (WebApiBDContext DbContext = new WebApiBDContext())
            {
                var usuario = DbContext.Usuario.FirstOrDefault(u => u.Email == loginViewModel.Email || u.Apelido == loginViewModel.Apelido);
                if (usuario == null)       
                    
                  return usuarioDados = "EmailApelido";

                
                
                usuario = DbContext.Usuario.FirstOrDefault(u => (u.Email == loginViewModel.Email || u.Apelido == loginViewModel.Apelido) && u.Senha == loginViewModel.Senha);

                if (usuario == null)
                
                    return usuarioDados = "Senha";
                
            }
            return usuarioDados;
        }


      
   

    public string ValidacaoCaracteresMinimo(Usuario usuario)
        {
            string validar = "";

            if (usuario.Senha.Length <= 3)
                validar = "Senha";

            if (usuario.Apelido.Length <= 3)
                validar = "Apelido";

            if (usuario.Apelido.Length <= 3)
                validar = "Nome";

            return validar;
        }

    }
}
