using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas_Net
{
    public class Pedido
    {
        public int Codigo { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime DataRecebimento { get; set; }
        public DateTime DataCancelamento { get; set; }
        public string Cliente { get; set; }

        private List<ItemPedido> lista = new List<ItemPedido>();

        public Pedido()
        {
            List<Pedido> lista = new List<Pedido>();
        }

        public void Cadastrar(string nome, int codigo)
        {
            Cliente = nome;
            Codigo = codigo;
        }

        public void CriarPedido(ItemPedido Pedido, int codigo)
        {
            Codigo += 1;
            lista.Add(Pedido);
        }

        public void Incluir(ItemPedido Pedido, int codigo)
        {
            Codigo = codigo;
            lista.Add(Pedido);
        }

        public double Total(double total = 0)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                total = lista[i].ValorUnitario * lista[i].Quantidade;
            }

            return total;
        }
    }
}
