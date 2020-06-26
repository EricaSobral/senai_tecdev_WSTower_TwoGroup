using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webApiWDTower.Domains;

namespace webApiWDTower.Interfaces
{
    public interface IJogadorRepository 
    {
        List<Jogador> ListarPorSelecao(int idSelecao);

        Jogador BuscarPorNome(string nome);

  
    }
}
