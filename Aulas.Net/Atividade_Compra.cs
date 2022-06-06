using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aulas_Net
{
    class Atividade_Compra
    {
        static void Main(string[] args)
        {
            string resposta = "sim";
            Pedido lista = new Pedido();      

            do
            {
                ItemPedido Pedido = new ItemPedido();

                Console.Write("Descrição:");
                Pedido.Descricao = Console.ReadLine();

                Console.Write("Valor:");
                Pedido.Valor_Unitario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantidade:");
                Pedido.Quantidade = int.Parse(Console.ReadLine());

                lista.Incluir(Pedido);

                Console.Write("Deseja realizar um novo pedido? (sim/nao)");
                resposta = Console.ReadLine();

                if (resposta == "nao")
                {
                    Console.WriteLine($"Valor Total do Pedido: {lista.Total(Pedido.Valor_Unitario):F2}");
                }

            } while (resposta == "sim");

        }
    }
}

