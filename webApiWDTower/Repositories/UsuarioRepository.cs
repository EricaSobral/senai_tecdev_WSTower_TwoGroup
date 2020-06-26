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

            if (usuarioNovaSenha.Apelido != null)
            {
                usuarioBuscado.Apelido = usuarioNovaSenha.Apelido;
            }

            ctx.Usuario.Update(usuarioBuscado);

            ctx.SaveChanges();
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

        public Usuario Login(LoginViewModel login, string email, string apelido, string senha)
        {
            throw new NotImplementedException();
        }

        //public Usuario Login(LoginViewModel login)
        //{

        //    return ctx.Usuario.FirstOrDefault(u => login.Apelido == u.Email || login.Email == u.Apelido && login.Senha == u.Senha);

        //    Usuario usuarioBuscado = ctx.Usuario
        //        .Include(u => u.UsuarioNavigation)
        //        .FirstOrDefault(u => (u.Email == email || u.Apelido == apelido) && u.Senha == senha);

        //    if (usuarioBuscado != null)
        //    {
        //        return usuarioBuscado;
        //    }

        //    return null;
        //}

        //public Usuario Login(LoginViewModel login, string email, string apelido, string senha)
        //{
        //    return ctx.Usuario.FirstOrDefault(u => login.Apelido == u.Email || login.Email == u.Apelido && login.Senha == u.Senha);
        //}
    }
}
