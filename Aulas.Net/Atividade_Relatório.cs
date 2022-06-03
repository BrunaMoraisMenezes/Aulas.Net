using System;

namespace Aulas_Net
{
    class Atividade_Relatório
    {
        static void XMain(string[] args)
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é a sua linguagem de programação favorita? ");
            string linguagemFavorita = Console.ReadLine();

            Console.WriteLine(""); //pular linha, para ficar mais apresentável o resultado
            Console.WriteLine("######################### RELATÓRIO ############################");
            Console.WriteLine("Olá, meu nome é {0}, tenho {1} anos e sou desenvolvedor(a) {2}", nome, idade, linguagemFavorita);
            Console.WriteLine("################################################################");

            Console.ReadKey();
        }
    }
}
