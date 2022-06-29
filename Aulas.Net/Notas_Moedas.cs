using System;
using System.Globalization;

namespace Notas_Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal valor = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            decimal[] trocoNotas = { 100, 50, 20, 10, 5, 2};
            int qtdNotas;

            Console.WriteLine("NOTAS: ");
            for (int i = 0; i < trocoNotas.Length; i++)
            {
                qtdNotas = (int)(valor / trocoNotas[i]);
                Console.WriteLine(qtdNotas + " nota(s) de R$ " + trocoNotas[i].ToString("F2"), CultureInfo.InvariantCulture);
                valor -= qtdNotas * trocoNotas[i];
            }

            Console.WriteLine();

            decimal[] trocoMoedas = { 1, 0.50M, 0.25M, 0.10M, 0.05M, 0.01M };
            int qtdMoedas;

            Console.WriteLine("MOEDAS: ");
            for (int i = 0; i < trocoMoedas.Length; i++)
            {
                qtdMoedas = (int)(valor / trocoMoedas[i]);
                Console.WriteLine(qtdMoedas + " moeda(s) de R$ " + trocoMoedas[i].ToString("F2"), CultureInfo.InvariantCulture);
                valor -= qtdMoedas * trocoMoedas[i];
            }
        }
    }
}
