using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Valets.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        public int ItensTotal { get; set; } // qnts item tenho banco
        public int ItensPorPagina { get; set; } // qnts item quero pagina
        public int PaginaAtual { get; set; } // qual pagina sendo exibida momento
        public int TotalPagina // qnts pagina irei ter
        {
            get{ return (int)Math.Ceiling((decimal)ItensTotal / ItensPorPagina); }

            

        }
    }
}