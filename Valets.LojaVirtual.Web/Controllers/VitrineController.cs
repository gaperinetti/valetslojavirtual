using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Valets.LojaVirtual.Dominio.Repositorio;
using Valets.LojaVirtual.Web.Models;

namespace Valets.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorio repositorio;
        public int ProdutosPorPagina = 8;

        // GET: Vitrine
        public ViewResult ListaProdutos(int pagina = 1)
        {
            repositorio = new ProdutosRepositorio();

            ProdutosViewModel model = new ProdutosViewModel
            {

                Produtos = repositorio.Produtos
                .OrderBy(p => p.Descricao)
                .Skip((pagina - 1) * ProdutosPorPagina)
                .Take(ProdutosPorPagina),

            Paginacao = new Paginacao
                {
                    PaginaAtual = pagina,
                    ItensPorPagina = ProdutosPorPagina,
                    ItensTotal = repositorio.Produtos.Count()
                    
                }

            };
                    
            

            return View(model);

            
        }
    }
}