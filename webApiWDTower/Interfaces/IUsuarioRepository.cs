using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webApiWDTower.Domains;
using webApiWDTower.ViewModels;

namespace webApiWDTower.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuario> Listar();

        Usuario BuscarPorId(int id);

        void Cadastrar(Usuario novoUsuario);

        Usuario Login(LoginViewModel login, string email, string apelido, string senha);

        void Atualizar(int id, Usuario usuarioAtualizado);

        void Deletar(int id);

        void AtualizarSenha(int id, Usuario usuarioNovaSenha);
    }
}
