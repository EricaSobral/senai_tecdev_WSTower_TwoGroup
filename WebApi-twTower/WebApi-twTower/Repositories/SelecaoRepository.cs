using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using WebApi_twTower.Contexts;
using WebApi_twTower.Domains;

namespace WebApi_twTower.Repositories
{
    public class SelecaoRepository
    {
       public List<Selecao> ListarSelecao()
        {
            using (WebApiBDContext webApi = new WebApiBDContext())
            {
                return webApi.Selecao.ToList();
            }
           
                
        }


    }
}
