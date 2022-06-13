using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class NotaFiscal
    {
        public Cabecalho Cabecalho { get; set; }
        public List<Produto> Produto { get; set; }
        public Rodape Rodape { get; set; }

        

        public void Imprimir(string nome, string cpf)
        {
            List<Produto> lista = new List<Produto>();

            Console.WriteLine("-----------------------NOTA FISCAL DE SAÍDA-----------------------");
            Console.WriteLine($"Número: {Guid.NewGuid()}");
            Console.WriteLine($"Cliente: {nome}");
            Console.WriteLine($"CPF: {cpf}");
            Console.WriteLine("Produto");
            foreach (var produtos in lista)
            {
                Console.WriteLine(produtos.Nome + " " + produtos.Quantidade + " " + produtos.Preco);
            }
            Console.WriteLine($"Total da Nota Fiscal: {Rodape.ValorTotal}");
        }
    }
}
