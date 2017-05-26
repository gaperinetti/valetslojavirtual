using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valets.LojaVirtual.Dominio.Entidades;

namespace Valets.LojaVirtual.Dominio.Entidades
{
    public class Carrinho
    {
        private readonly List<ItemCarrinho> itemCarrinho = new List<ItemCarrinho>();
        
        //Adicionar
        public void AdicionarItem(Produto produto, int quantidade)
        {
            ItemCarrinho item = itemCarrinho.FirstOrDefault(p => p.Produto.ProdutoId == produto.ProdutoId);

            if(item == null)
            {
                itemCarrinho.Add(new ItemCarrinho
                {
                    Produto = produto,
                    Quantidade = quantidade

                });
            }
            else
            {
                item.Quantidade += quantidade;
            }

        }


        // Remover item

        public void RemevorItem(Produto produto)
        {
            itemCarrinho.RemoveAll(l => l.Produto.ProdutoId == produto.ProdutoId);
        }



        //Obter o valor total

        public decimal ObterValorTotal()
        {
            return itemCarrinho.Sum(e => e.Produto.Preco * e.Quantidade);
        }

        //Limpar carrinho

        public void LimparCarrinho()
        {
            itemCarrinho.Clear();
        }

        //Itens carrinho

        public IEnumerable<ItemCarrinho> ItensCarrinho
        {
            get { return itemCarrinho; }
        }


    }


    public class ItemCarrinho
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }

}