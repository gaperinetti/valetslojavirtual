using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Valets.LojaVirtual.Dominio.Repositorio;

namespace Valets.LojaVirtual.Web.Controllers
{
    public class CategoriaController : Controller
    {
        private ProdutosRepositorio repositorio;

        public PartialViewResult Menu(string categoria = null)
        {
            ViewBag.CategoriaSelecionada = categoria;

            repositorio = new ProdutosRepositorio();

            IEnumerable<string> categorias = repositorio.Produtos
                .Select(c => c.Categoria)
                .Distinct()
                .OrderBy(c => c);

            return PartialView(categorias);


        }
    }
}

