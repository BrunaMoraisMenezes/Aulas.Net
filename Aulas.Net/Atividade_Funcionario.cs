using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aulas_Net
{
    class Atividade_Funcionario
    {
        static void xMain(string[] args)
        {
            Console.WriteLine("---------DADOS DO FUNCIONÁRIO---------");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("Cargo: ");
            string cargo = Console.ReadLine();
            Console.Write("Salário: ");
            decimal salario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Funcionario func = new Funcionario(nome, cpf, cargo, salario);

            Console.WriteLine("---------DADOS DO FUNCIONÁRIO---------");
            Console.WriteLine(func.ToString());

        }
    }
}
