using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webApiWDTower.Contexts;
using webApiWDTower.Domains;
using webApiWDTower.Interfaces;

namespace webApiWDTower.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        WebApiBDContext ctx = new WebApiBDContext();
        public List<Jogo> ListarDataJogo(DateTime data)
        {
            return ctx.Jogo.ToList().FindAll(x => Convert.ToDateTime(x.Data).Date == data);
            
        }

        public List<Jogo> ListarEstadioJogo(string estadio)
        {
            return ctx.Jogo.ToList().FindAll(x => x.Estadio == estadio);
        }

        public List<Jogo> ListarJogos()
        {
            return ctx.Jogo.ToList();
        }

        public List<Jogo> ListarSelecaoJogo(string selecao)
        {

            return ctx.Jogo.Where(x => x.SelecaoVisitanteNavigation.Nome == selecao || x.SelecaoCasaNavigation.Nome == selecao).ToList();
        }
    }
}
