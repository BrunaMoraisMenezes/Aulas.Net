using System;
using System.Globalization;

namespace Aulas_Net
{
    class Banco
    {
        static void xMain(string[] args)
        {
            Console.WriteLine("------- PRIMEIRA CONTA -------");
            Conta1 conta1 = new Conta1();
            Console.Write("Digite o Titular da Conta: ");
            conta1.Titular = Console.ReadLine();
            Console.Write("Digite a Agência da Conta: ");
            conta1.Agencia = int.Parse(Console.ReadLine());
            Console.Write("Digite o Número da Conta: ");
            conta1.NumeroConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o Saldo atual da Conta: ");
            conta1.Saldo = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\n------- SALDO INICIAL -------");
            Console.WriteLine("SALDO: " + conta1.Saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("\n------- SALDO APÓS DEPÓSITO DE 500,00 -------");
            conta1.Depositar(500);
            Console.WriteLine("SALDO: " + conta1.Saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("\n------- SALDO APÓS SAQUE DE 300,00 -------");
            conta1.Sacar(300);
            Console.WriteLine("SAQUE: " + conta1.Saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("\n------- SEGUNDA CONTA -------");
            Conta1 conta2 = new Conta1();
            Console.Write("Digite o Titular da Conta: ");
            conta2.Titular = Console.ReadLine();
            Console.Write("Digite a Agência da Conta: ");
            conta2.Agencia = int.Parse(Console.ReadLine());
            Console.Write("Digite o Número da Conta: ");
            conta2.NumeroConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o Saldo atual da Conta: ");
            conta2.Saldo = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\n------- SALDO INICIAL -------");
            Console.WriteLine("SALDO: " + conta2.Saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("\n------- SALDO APÓS DEPÓSITO DE 1.500,00 -------");
            conta2.Depositar(1500);
            Console.WriteLine("SALDO: " + conta2.Saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("\n------- SALDOS APÓS TRANSFERÊNCIA DE 100,00 DA PRIMEIRA CONTA PARA SEGUNDA CONTA -------");
            conta1.Transferir(conta2, 100);
            Console.WriteLine("SALDO DA PRIMEIRA CONTA: " + conta1.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("SALDO DA SEGUNDA CONTA: " + conta2.Saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("\n------- SALDOS APÓS TRANSFERÊNCIA DE 50,00 DA SEGUNDA CONTA PARA PRIMEIRA CONTA-------");
            conta2.Transferir(conta1, 50);
            Console.WriteLine("SALDO DA PRIMEIRA CONTA: " + conta1.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("SALDO DA SEGUNDA CONTA: " + conta2.Saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("\n------- RELATÓRIOS -------");
            Console.WriteLine(conta1.ToString());
            Console.WriteLine(conta2.ToString());
        }
    }
}
