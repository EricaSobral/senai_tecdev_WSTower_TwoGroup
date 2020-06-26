using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webApiWDTower.Contexts;
using webApiWDTower.Domains;
using webApiWDTower.Interfaces;

namespace webApiWDTower.Repositories
{
    public class SelecaoRepository : ISelecaoRepository
    {
       WebApiBDContext ctx = new WebApiBDContext();

        public List<Selecao> ListarSelecao()
        {
            return ctx.Selecao.ToList();
        }
    }
}
