using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Valets.LojaVirtual.Dominio.Repositorio;

namespace Valets.LojaVirtual.Web.Controllers
{
    public class CategoriaController : Controller
    {
        private ProdutosRepositorio repositorio;
        
        // GET: Categoria
        public PartialViewResult Menu(string categoria = null)
        {
            ViewBag.CategoriaSelection = categoria;
            repositorio = new ProdutosRepositorio();

            IEnumerable<string> categorias = repositorio.Produtos
                .Select(c => categoria)
                .Distinct()
                .OrderBy(c => c);

            return PartialView(categorias);
        }
    }
}