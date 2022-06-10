using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_Net
{
    public class ItemPedido
    {
        public string Descricao { get; set; }
        public double ValorUnitario { get; set; }
        public int Quantidade { get; set; }
        public int FormaPagamento { get; set; }
    }
}
