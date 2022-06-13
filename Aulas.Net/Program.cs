using System;
using System.Collections.Generic;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            NotaFiscal notaFiscal = new NotaFiscal();

            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = "André Camillo";
            pessoaFisica.CPF = "11122233344";

            Cabecalho cabecalho = new Cabecalho();
            cabecalho.Cliente = pessoaFisica;

            List<Produto> lista = new List<Produto>();

            Produto primeiroProduto = new Produto();
            primeiroProduto.Nome = "Notebook Thinkpad";
            primeiroProduto.Quantidade = 1;
            primeiroProduto.Preco = 10000;

            Produto segundoProduto = new Produto();
            segundoProduto.Nome = "Mouse Logitech";
            segundoProduto.Quantidade = 3;
            segundoProduto.Preco = 120;

            lista.Add((primeiroProduto));
            lista.Add(segundoProduto);

            foreach (var produtos in lista)
            {
                Console.WriteLine(produtos);
            }
            notaFiscal.Imprimir(pessoaFisica.Nome, pessoaFisica.CPF);
        }
    }
}
