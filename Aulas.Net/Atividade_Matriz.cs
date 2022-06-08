using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Aulas_Net
{
    class Atividade_Matriz
    {
        static void xMain(string[] args)
        {
            int[,] matriz = new int[3, 3];

            matriz[0, 0] = 2;
            matriz[0, 1] = 10;
            matriz[1, 1] = 0;
            matriz[1, 2] = 3;
            matriz[2, 1] = 1;

            Console.WriteLine("---------IMPRIMINDO A MATRIZ---------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-------SOMA DA LINHA 1---------");
            int somaLinha = matriz[0, 0] + matriz[0, 1] + matriz[0, 2];
            Console.WriteLine(somaLinha);

            Console.WriteLine("-------SOMA DA COLUNA 2---------");
            int somaColuna = matriz[0, 1] + matriz[1, 1] + matriz[2, 1];
            Console.WriteLine(somaColuna);

            Console.WriteLine("-------MULTIPLICACAO DA BANDEIRINHA PELO VALOR DA LINHA 2 E COLUNA 3---------");
            int multiplicacao = (matriz[0, 1]) * (matriz[1, 0] + matriz[1, 1] + matriz[1, 2]) * (matriz[0, 2] + matriz[1, 2] + matriz[2, 2]);
            Console.WriteLine(multiplicacao);
        }
    }
}
