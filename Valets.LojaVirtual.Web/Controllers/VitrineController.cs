using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Valets.LojaVirtual.Dominio.Repositorio;

namespace Valets.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorio repositorio;
        public int ProdutosPorPagina = 3;

        // GET: Vitrine
        public ActionResult ListaProdutos(int pagina = 1)
        {
            repositorio = new ProdutosRepositorio();
            var produtos = repositorio.Produtos
                .OrderBy(p => p.Descricao)
                .Skip((pagina - 1) * ProdutosPorPagina)
                .Take(ProdutosPorPagina);

            return View(produtos);

            
        }
    }
}