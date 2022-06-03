using System;
using System.Collections.Generic;

namespace Aulas_Net
{
    class Atividade_Impares
    {
        static void XMain(string[] args)
        {
            int impar = 0, numero, i = 0;
            Console.WriteLine("--------VETOR--------");
            int[] vetor = new int[100];

            for (i = 0; i < 100; i++)
            {
                Console.Write($"{i}° posição:");
                vetor[i] = int.Parse(Console.ReadLine());

                numero = vetor[i] % 2;

                if (numero != 0)
                {
                    impar++;
                }
            }

            Console.WriteLine("--------QUANTIDADE DE NÚMEROS ÍMPARES--------");
            Console.WriteLine(impar);
        }
    }
}
