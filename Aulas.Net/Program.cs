using System;
using System.Collections.Generic;
using System.Globalization;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carro> lista = new List<Carro>();

            Console.Write("Quantidade de veículos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                double kmInicial = double.Parse(vect[1], CultureInfo.InvariantCulture);
                double kmFinal = double.Parse(vect[2], CultureInfo.InvariantCulture);
                lista.Add(new Carro(vect[0], kmInicial, kmFinal));
            }
            Generica generica = new Generica();
            Carro c = generica.Max(lista);
            Console.WriteLine("Veículo com mais quilômetros rodados: ");
            Console.WriteLine(c);
        }
    }
}
