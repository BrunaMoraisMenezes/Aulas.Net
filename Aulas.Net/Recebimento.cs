using Restaurante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_Net
{
    public class Recebimento
    {
        public int Codigo { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime DataRecebimento { get; set; }
        public DateTime DataCancelamento { get; set; }
        public int FormaPagamento { get; set; }

        private List<Pedido> lista = new List<Pedido>();

        public Recebimento()
        {
            List<Pedido> lista = new List<Pedido>();
        }
    }
}
