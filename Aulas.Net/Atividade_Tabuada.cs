using System;

namespace Aulas_Net
{
    class Atividade_Tabuada
    {
        static void xMain(string[] args)
        {
            Console.WriteLine("------------- TABUADA DO DOIS -------------");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("2 X {0} = {1}", i, 2 * i);
            }

            Console.WriteLine("------------- TABUADA DO TRÊS -------------");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("3 X {0} = {1}", i, 3 * i);
            }

            Console.WriteLine("------------- TABUADA DO CINCO -------------");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("5 X {0} = {1}", i, 5 * i);
            }
        }
    }
}
