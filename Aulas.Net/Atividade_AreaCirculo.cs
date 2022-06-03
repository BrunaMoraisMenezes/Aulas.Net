using System;
using System.Globalization;

namespace Aulas_Net
{
    class Atividade_AreaCirculo
    {
        static void xMain(string[] args)
        {
            //const double PI = 3.14159;

            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = Math.PI * (Math.Pow(raio, 2));

            Console.WriteLine("Área do Círculo: " + area.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
