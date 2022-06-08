using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Aulas_Net
{
    class Atividade_SwitchCase
    {
        static void xMain(string[] args)
        {
            List<Produto> lista = new List<Produto>();
            lista.Add(new Produto("HD", 1000));
            lista.Add(new Produto("SSD", 2000));
            lista.Add(new Produto("Mouse Logitech", 4500));
            lista.Add(new Produto("Monitor", 5500));
            lista.Add(new Produto("Thinkpad", 10000));
            lista.Add(new Produto("Processador", 9000));
            lista.Add(new Produto("Macbook", 16000));
            lista.Add(new Produto("Teclado", 150));
            lista.Add(new Produto("Pen Drive", 200));
            lista.Add(new Produto("Fone", 900));

            Console.WriteLine("Digite um valor de 1 à 5: ");
            int valor = int.Parse(Console.ReadLine());

            switch (valor)
            {
                case 1:
                    Console.WriteLine(lista[0]);
                    break;
                case 2:
                    Console.WriteLine(lista[1]);
                    break;
                case 3:
                    Console.WriteLine(lista[2]);
                    break;
                case 4:
                    Console.WriteLine(lista[3]);
                    break;
                case 5:
                    Console.WriteLine(lista[4]);
                    break;
                default:
                    Console.WriteLine("Não foi possível consultar a lista!");
                    break;
            }
        }
    }
}
