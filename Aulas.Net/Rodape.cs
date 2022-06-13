using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Rodape : Produto
    {
        public decimal ValorTotal { get; set; }

        List<Produto> lista = new List<Produto>();

        public decimal Total(decimal preco, int quantidade, decimal total)
        {
            Preco = preco;
            Quantidade = quantidade;
            for (int i = 0; i < lista.Count; i++)
            {
                total = lista[i].Preco * lista[i].Quantidade;
            }

            return total;
        }
    }
}
