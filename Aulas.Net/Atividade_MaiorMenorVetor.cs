using System;
using System.Collections.Generic;

namespace Aulas_Net
{
    class Atividade_MaiorMenorVetor
    {
        static void xMain(string[] args)
        {
            int i, maior = 0, menor = 0, posicaomaior = 0, posicaomenor = 0;
            int[] vetor = new int[20];

            for (i = 0; i <= 20; i++)
            {
                Console.Write($"Digite a {i} posição: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (i == 1) 
                { 
                    maior = vetor[i]; 
                    menor = vetor[i]; 
                }
                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                    posicaomaior = i;
                }
                else
                {
                    if (vetor[i] < menor)
                    {
                        menor = vetor[i];
                        posicaomaior = i;
                    }
                }
            }
            Console.WriteLine($"Maior valor é {maior} na posição {posicaomaior}");
            Console.WriteLine($"Menor valor é {menor} na posição {posicaomenor}");
        }
    }
}
