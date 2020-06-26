using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webApiWDTower.Domains;

namespace webApiWDTower.Interfaces
{
    interface ISelecaoRepository
    {
        List<Selecao> Listar();

        Selecao BuscarPorId(int id);

        void Cadastrar(Selecao novaSelecao);

        void Atualizar(int id, Selecao selecaoAtualizada);

        void Deletar(int id);
    }
}
