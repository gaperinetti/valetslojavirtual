using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valets.LojaVirtual.Dominio.Entidades;

namespace Valets.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly EfDbContext context = new EfDbContext();

        public IEnumerable<Produto> Produtos {

            get { return context.Produtos; }

        }    

    }
}
