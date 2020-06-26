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
    public class JogadorRepository : IJogadorRepository
    {
        WebApiBDContext ctx = new WebApiBDContext();

        public Jogador BuscarPorNome(string nome)
        {
            Jogador jogadorBuscado = ctx.Jogador.FirstOrDefault(j => j.Nome == nome);

            if(jogadorBuscado != null)
            {
                return jogadorBuscado;
            }
            return null;
        }

        public List<Jogador> ListarPorSelecao(int idSelecao)
        {
            return ctx.Jogador.ToList().FindAll(j => j.SelecaoId == idSelecao);
        }

    }
}
