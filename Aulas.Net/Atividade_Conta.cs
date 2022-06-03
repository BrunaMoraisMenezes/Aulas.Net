using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aulas_Net
{
    class Atividade_Conta
    {
        static void xMain(string[] args)
        {
            Console.WriteLine("---------CONTA---------");
            Console.Write("Titular: ");
            string titular = Console.ReadLine();
            Console.Write("Saldo: ");
            decimal saldo = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Conta conta = new Conta();

            Console.WriteLine("---------DADOS DA CONTA---------");
            Console.WriteLine($"Titular: {titular}");
            Console.WriteLine($"Saldo: {saldo:F2}");
        }
    }
}
