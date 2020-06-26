using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webApiWDTower.Domains;

namespace webApiWDTower.Interfaces
{
    public interface IJogoRepository
    {
        List<Jogo> Listar();

        Jogo BuscarPorId(int id);

        void Cadastrar(Jogo novoJogo);


        void Atualizar(int id, Jogo jogoAtualizado);

        void Deletar(int id);
    }
}
