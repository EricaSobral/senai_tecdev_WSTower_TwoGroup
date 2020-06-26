using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webApiWDTower.Domains;

namespace webApiWDTower.Interfaces
{

    public interface IJogoRepository
    {
        public List<Jogo> ListarJogos();

        public List<Jogo> ListarDataJogo(DateTime data);

        public List<Jogo> ListarEstadioJogo(string estadio);

        public List<Jogo> ListarSelecaoJogo(string selecao);
    }
}
