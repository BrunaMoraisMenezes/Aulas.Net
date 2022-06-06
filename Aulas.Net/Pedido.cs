using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_Net
{
    class Pedido
    {
        private List<ItemPedido> lista = new List<ItemPedido>();

        public void Incluir(ItemPedido Pedido)
        {
            lista.Add(Pedido);
        }

        public double Total(double total = 0)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                total += lista[i].Valor_Unitario * lista[i].Quantidade;
            }

            return total;
        }
    }
}
