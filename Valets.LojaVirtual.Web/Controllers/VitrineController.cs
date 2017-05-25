using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Valets.LojaVirtual.Dominio.Repositorio;
using Valets.LojaVirtual.Web.Models;

namespace Quiron.LojaVirtual.Web.Controllers
{


    public class VitrineController : Controller
    {
        private ProdutosRepositorio repositorio;
        public int ProdutosPorPagina = 5;


        public ViewResult ListaProdutos(string categoria,int pagina = 1)
        {
            repositorio = new ProdutosRepositorio();

            ProdutosViewModel model = new ProdutosViewModel
            {

                Produtos = repositorio.Produtos
                    .Where(p => categoria == null || p.Categoria.Trim() == categoria)
                    .OrderBy(p => p.Descricao)
                    .Skip((pagina - 1) * ProdutosPorPagina)
                    .Take(ProdutosPorPagina),



                Paginacao = new Paginacao
                {
                    PaginaAtual = pagina,
                    ItensPorPagina = ProdutosPorPagina,
                    ItensTotal = categoria == null ? repositorio.Produtos.Count() : repositorio.Produtos.Count(e => e.Categoria == categoria)
                },

                CategoriaAtual = categoria
            };


            return View(model);
        }
    }
}