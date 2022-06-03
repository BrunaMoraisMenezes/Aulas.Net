using System;
using System.Globalization;

namespace Aulas_Net
{
    class Atividade_NumerosReais
    {
        static void xMain(string[] args)
        {
            Console.Write("Digite um número: ");
            double numero = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            int i = 0;
            double media = numero;


            while (numero != 0)
            {
                Console.Write("Digite um número: ");
                numero = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                media += numero;
                i++;
            }

            Console.WriteLine("Quantidade de números digitados: {0}", i);
            media /= i;
            Console.WriteLine("Média dos números: {0}", media);
        }
    }
}
