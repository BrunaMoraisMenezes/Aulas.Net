using System;
using System.Globalization;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FazerCalculo calculo = new FazerCalculo();

                Console.WriteLine("--------------CALCULADORA--------------");
                Console.Write("Digite o primeiro valor: ");
                calculo.PrimeiroValor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Digite o segundo valor: ");
                calculo.SegundoValor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("--------------OPERAÇÕES--------------");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão"); 
                Console.Write("Digite o código da operação desejada: ");
                int operacaoMatematica = int.Parse(Console.ReadLine());

                switch (operacaoMatematica)
                {
                    case 1:
                        calculo.Somar();
                        Console.WriteLine("Resultado: " + calculo.Adicao);
                        break;
                    case 2:
                        calculo.Subtrair();
                        Console.WriteLine("Resultado: " + calculo.Subtracao);
                        break;
                    case 3:
                        calculo.Multiplicar();
                        Console.WriteLine("Resultado: " + calculo.Multiplicacao);
                        break;
                    case 4:
                        calculo.Dividir();
                        Console.WriteLine("Resultado: " + calculo.Divisao);
                        break;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Formato de entrada inválido", ex.Message);
            }
        }
    }
}
