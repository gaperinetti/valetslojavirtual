using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;
using Valets.LojaVirtual.Web.HtmlHelpers;
using Valets.LojaVirtual.Web.Models;

namespace Valets.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestValets
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestandoPaginacao()
        {
            HtmlHelper html = null;

            Paginacao paginacao = new Paginacao
            {
                PaginaAtual = 2,
                ItensPorPagina = 28,
                ItensTotal = 10
            };

            Func<int, string> paginaUrl = i => "Pagina" + i;


            //Act
            MvcHtmlString resultado = html.PageLinks(paginacao, paginaUrl);


            //Assert

           
        }


    }
}
