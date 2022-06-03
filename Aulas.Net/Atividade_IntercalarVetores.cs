using System;
using System.Collections.Generic;

namespace Aulas_Net
{
    class Atividade_IntercalarVetores
    {
        static void xMain(string[] args)
        {
            Console.WriteLine("--------PRIMEIRO VETOR--------");
            int[] primeiroVetor = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i}° posição:");
                primeiroVetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("--------SEGUNDO VETOR--------");
            int[] segundoVetor = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i}° posição:");
                segundoVetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("--------VETOR INTERCALADO--------");
            int[] vetorIntercalado = new int[20];
            int posicao = 0;
            for (int i = 0; i < 10; i++)
            {
                vetorIntercalado[posicao] = primeiroVetor[i];
                posicao += 2;
            }
            posicao = 1;
            for (int i = 0; i < 10; i++)
            {
                vetorIntercalado[posicao] = segundoVetor[i];
                posicao += 2;
            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"{i}° posição: {vetorIntercalado[i]}");
            }
        }
    }
}
