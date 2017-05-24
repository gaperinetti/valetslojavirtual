using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Valets.LojaVirtual.Dominio.Repositorio;

namespace Valets.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {
        private ProdutosRepositorio repositorio;
        
        // GET: Produtos
        public ActionResult Index()
        {
            repositorio = new ProdutosRepositorio();
            var produtos = repositorio.Produtos.Take(10);

            return View(produtos);
        }
    }
}