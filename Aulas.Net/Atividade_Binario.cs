using System;

namespace Aulas_Net
{
    class Atividade_Binario
    {
        static void xMain(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Digite um número diferente: ");
                numero = int.Parse(Console.ReadLine());
            } while (numero != 0 && numero != 1);
      
        }
    }
}
