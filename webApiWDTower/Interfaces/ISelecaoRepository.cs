using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webApiWDTower.Domains;

namespace webApiWDTower.Interfaces
{
    interface ISelecaoRepository
    {
        public List<Selecao> ListarSelecao();
    }
}
