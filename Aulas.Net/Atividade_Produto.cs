using System;
using System.Collections.Generic;
using System.Linq;

namespace Aulas_Net
{
    class Atividade_Produto
    {
        static void xMain(string[] args)
        {
            List<Produto> lista = new List<Produto>();
            string nome;
            decimal preco;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Insira o nome do produto: ");
                nome = Console.ReadLine();

                Console.Write("Insira o preco do produto: ");
                preco = decimal.Parse(Console.ReadLine());

                lista.Add(new Produto(nome, preco));
            }

            Console.WriteLine("---------IMPRIMINDO A LISTA---------");
            foreach (var produtos in lista)
            {
                Console.WriteLine(produtos);
            }
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("---------PRECOS EM ORDEM DECRESCENTE---------");
            List<Produto> decrescente = lista.OrderByDescending(x => x.Preco).ToList();
            foreach (var produtos in decrescente)
            {
                Console.WriteLine(produtos);
            }
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("---------VERIFICANDO SE HÁ O MOUSE LOGITECH---------");
            int existe = lista.FindIndex(x => x.Nome == "Mouse Logitech");
            if (existe != -1)
                Console.WriteLine($"Este produto está na lista na posição {existe}");
            else
                Console.WriteLine("Este produto não está na lista");
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("---------INSERÇÃO DE VALORES---------");
            Console.WriteLine("Nome do produto que deseja inserir: ");
            nome = Console.ReadLine();
            Console.WriteLine("Preço do produto que deseja inserir: ");
            preco = decimal.Parse(Console.ReadLine());
            lista.Insert(4, new Produto(nome, preco));

            foreach (var produtos in lista)
            {
                Console.WriteLine(produtos);
            }
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("---------INSERÇÃO DE VALOR AO FINAL DA LISTA---------");
            Console.WriteLine("Nome do produto que deseja inserir: ");
            nome = Console.ReadLine();
            Console.WriteLine("Preço do produto que deseja inserir: ");
            preco = decimal.Parse(Console.ReadLine());
            lista.Insert(lista.Count, new Produto(nome, preco));

            foreach (var produtos in lista)
            {
                Console.WriteLine(produtos);
            }
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("---------QUANTIDADE DE PRODUTOS NA LISTA---------");
            int quantidade = lista.Count;
            Console.WriteLine(quantidade);
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("---------TODOS OS VALORES QUE COMEÇAM COM A---------");
            List<Produto> produtoComA = lista.FindAll(x => x.Nome.ToUpper() == "A");
            foreach (var produtos in produtoComA)
            {
                Console.WriteLine(produtos);
            }
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("---------REMOVENDO A POSICAO 8---------");
            lista.RemoveAt(7);
            foreach (var produtos in lista)
            {
                Console.WriteLine(produtos);
            }
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
