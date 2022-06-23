using System;
using System.IO;
using System.Collections.Generic;

namespace Arquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o endereco: ");
            string endereco = Console.ReadLine();

            Arquivo arquivo = new Arquivo(endereco);

            try
            {
                arquivo.ListaDiretorios();
                arquivo.ListaFuncionarios();
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine();
                Console.WriteLine("Endereco Inválido");
            }
        }
    }
}
