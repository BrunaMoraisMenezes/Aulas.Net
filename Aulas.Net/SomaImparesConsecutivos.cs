using System;
using System.Linq;

namespace Impares
{
    class Program
    {
        static void Main(string[] args)
        {
            int somaImpar = 0, ordenar = 0;
            Console.Write("Digite quantidade de testes: ");
            int quantidade = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite o valor de X: ");
                int valorX = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor de Y: ");
                int valorY = int.Parse(Console.ReadLine());
                if (valorX < valorY || valorX > valorY)
                {
                    if (valorX > valorY)
                    {
                        ordenar = valorX;
                        valorX = valorY;
                        valorY = ordenar;
                    }
                    for (int j = 0; j < quantidade; j++)
                    {
                        while (valorX < (valorY - 1))
                        {
                            valorX += 1;
                            if (valorX % 2 != 0)
                            {
                                somaImpar += valorX;
                            }
                        }
                    }
                    Console.WriteLine("------------");
                    Console.WriteLine(somaImpar);
                    Console.WriteLine("------------");
                    somaImpar = 0;
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}