using System;
using System.Globalization;

namespace Aulas_Net
{
    class Atividade_Calculadora
    {
        static void xMain(string[] args)
        {
            Console.WriteLine("--------------CALCULADORA--------------");
            Console.Write("Digite o primeiro valor: ");
            double primeiroValor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o segundo valor: ");
            double segundoValor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o código da operação desejada: ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            int operacaoMatematica = int.Parse(Console.ReadLine());
            double resultado = 0;

            switch (operacaoMatematica)
            {
                case 1:
                    resultado = primeiroValor + segundoValor;
                    break;
                case 2:
                    resultado = primeiroValor - segundoValor;
                    break;
                case 3:
                    resultado = primeiroValor * segundoValor;
                    break;
                case 4:
                    resultado = primeiroValor / segundoValor;
                    break;
                default:
                    Console.WriteLine("Digite um código válido");
                    break;
            }

            Console.WriteLine("Resultado completo: " + resultado.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("Resultado com 2 casas decimais: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Resultado apenas com a parte inteira: " + (int) resultado);

            Console.ReadKey();
        }
    }
}
