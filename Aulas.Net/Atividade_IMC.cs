using System;
using System.Globalization;

namespace Aulas_Net
{
    class Atividade_IMC
    {
        static void xMain(string[] args)
        {
            Console.Write("Digite seu peso: ");
            double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imc = peso / (Math.Pow(altura, 2));

            Console.WriteLine("-------------- IMC --------------");
            if (imc < 17)
                Console.WriteLine("Seu IMC é: " + imc.ToString("F2", CultureInfo.InvariantCulture) + "\nMuito abaixo do peso!");
            else if (imc >= 17 && imc <= 18.49)
                Console.WriteLine("Seu IMC é: " + imc.ToString("F2", CultureInfo.InvariantCulture) + "\nAbaixo do peso!");
            else if(imc >= 18.5 && imc <= 24.99)
                Console.WriteLine("Seu IMC é: " + imc.ToString("F2", CultureInfo.InvariantCulture) + "\nPeso normal!");
            else if(imc >= 25 && imc <= 29.99)
                Console.WriteLine("Seu IMC é: " + imc.ToString("F2", CultureInfo.InvariantCulture) + "\nAcima do peso!");
            else if(imc >= 30 && imc <= 34.99)
                Console.WriteLine("Seu IMC é: " + imc.ToString("F2", CultureInfo.InvariantCulture) + "\nObesidade I");
            else if(imc >= 35 && imc <= 39.99)
                Console.WriteLine("Seu IMC é: " + imc.ToString("F2", CultureInfo.InvariantCulture) + "\nObesidade II");
            else
                Console.WriteLine("Seu IMC é: " + imc.ToString("F2", CultureInfo.InvariantCulture) + "\nObesidade III (Mórbida)");

            Console.ReadKey();
        }
    }
}
