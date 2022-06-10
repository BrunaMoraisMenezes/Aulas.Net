using Restaurante;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aulas_Net
{
    class Atividade_Compra
    {
        static void Main(string[] args)
        {
            string resposta = "sim", nome;
            double total = 0, valorTotal = 0, formaPagamento = 0, pagamento = 0;
            int codigo = 0, qtdParcelas = 0;
            var situacao = SituacoesEnum.Novo;
            DateTime dataPedido = DateTime.Now;
            DateTime dataVencimento = dataPedido.AddDays(30);
            ItemPedido Pedido = new ItemPedido();
            Pedido lista = new Pedido();

            Console.WriteLine("---------------MENU---------------");
            Console.WriteLine("1 - Cadastrar cliente");
            Console.WriteLine("2 - Criar pedido");
            Console.WriteLine("3 - Receber pagamento");
            Console.WriteLine("4 - Relatório dos pedidos criados");
            Console.WriteLine("5 - Cancelar pedido");
            Console.WriteLine("6 - Sair do sistema");
            Console.Write("Selecione uma opção: ");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                Console.Write("Informe o nome do cliente: ");
                nome = Console.ReadLine();
                Console.Write("Informe o codigo do cliente: ");
                codigo = int.Parse(Console.ReadLine());
                lista.Cadastrar(nome, codigo);

                Console.WriteLine("Cliente cadastrado!");

                Console.WriteLine("---------------MENU---------------");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Criar pedido");
                Console.WriteLine("3 - Receber pagamento");
                Console.WriteLine("4 - Relatório dos pedidos criados");
                Console.WriteLine("5 - Cancelar pedido");
                Console.WriteLine("6 - Sair do sistema");
                Console.Write("Selecione uma opção: ");
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 2)
                {
                    situacao = SituacoesEnum.Novo;
                    do
                    {
                        do
                        {
                            Console.Write("Descrição:");
                            Pedido.Descricao = Console.ReadLine();

                            Console.Write("Valor:");
                            Pedido.ValorUnitario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            Console.Write("Quantidade:");
                            Pedido.Quantidade = int.Parse(Console.ReadLine());

                            lista.Incluir(Pedido, codigo);

                            Console.Write("Deseja realizar um novo pedido? (sim/nao)");
                            resposta = Console.ReadLine();

                            total = lista.Total(Pedido.ValorUnitario);

                            if (resposta.Trim().ToUpper() == "NAO" || resposta.Trim().ToUpper() == "F")
                            {
                                Console.WriteLine($"Pedido realizado! Status: {SituacoesEnum.Novo}");

                                Console.WriteLine("---------------MENU---------------");
                                Console.WriteLine("1 - Cadastrar cliente");
                                Console.WriteLine("2 - Criar pedido");
                                Console.WriteLine("3 - Receber pagamento");
                                Console.WriteLine("4 - Relatório dos pedidos criados");
                                Console.WriteLine("5 - Cancelar pedido");
                                Console.WriteLine("6 - Sair do sistema");
                                Console.Write("Selecione uma opção: ");
                                escolha = int.Parse(Console.ReadLine());
                            }
                        } while (resposta == "sim");

                    } while (resposta == "sim");
                }
                if (escolha == 3)
                {
                    Console.WriteLine("---------------MENU---------------");
                    Console.WriteLine("1 - Cadastrar cliente");
                    Console.WriteLine("2 - Criar pedido");
                    Console.WriteLine("3 - Receber pagamento");
                    Console.WriteLine("     3.1 - À vista");
                    Console.WriteLine("     3.2 - À prazo");
                    Console.WriteLine("     9 - Sair");
                    Console.WriteLine("4 - Relatório dos pedidos criados");
                    Console.WriteLine("5 - Cancelar pedido");
                    Console.WriteLine("6 - Sair do sistema");
                    Console.Write("Selecione uma opção: ");
                    formaPagamento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (formaPagamento == 3.1)
                    {
                        formaPagamento = (double)PagamentoEnum.Vista;
                        situacao = SituacoesEnum.Pago;
                        Console.WriteLine($"Pagamento realizado! Status: {SituacoesEnum.Pago}");

                        Console.WriteLine("---------------MENU---------------");
                        Console.WriteLine("1 - Cadastrar cliente");
                        Console.WriteLine("2 - Criar pedido");
                        Console.WriteLine("3 - Receber pagamento");
                        Console.WriteLine("4 - Relatório dos pedidos criados");
                        Console.WriteLine("5 - Cancelar pedido");
                        Console.WriteLine("6 - Sair do sistema");
                        Console.Write("Selecione uma opção: ");
                        escolha = int.Parse(Console.ReadLine());

                        lista.Incluir(Pedido, codigo);
                    }
                    else if (formaPagamento == 3.2)
                    {
                        Console.WriteLine("Digite a quantidade de parcelas desejadas: ");
                        qtdParcelas = int.Parse(Console.ReadLine());
                        valorTotal = total / qtdParcelas;
                        formaPagamento = (double)PagamentoEnum.Prazo;
                        Console.WriteLine("Parcelas: ");
                        for (int i = 1; i <= qtdParcelas; i++)
                        {
                            Console.WriteLine("Valor da Parcela  |  Parcela  |  Data do Vencimento ");
                            Console.WriteLine("        " + valorTotal + "         |" + i + "          |" + dataPedido.AddDays(i * 30) + "|");
                        }
                        situacao = SituacoesEnum.Pago;

                        Console.WriteLine($"Pagamento parcelado!");

                        Console.WriteLine("---------------MENU---------------");
                        Console.WriteLine("1 - Cadastrar cliente");
                        Console.WriteLine("2 - Criar pedido");
                        Console.WriteLine("3 - Receber pagamento");
                        Console.WriteLine("4 - Relatório dos pedidos criados");
                        Console.WriteLine("5 - Cancelar pedido");
                        Console.WriteLine("6 - Sair do sistema");
                        Console.Write("Selecione uma opção: ");
                        escolha = int.Parse(Console.ReadLine());

                        lista.Incluir(Pedido, codigo);
                    }
                    else if (formaPagamento == 9)
                    {
                        Console.WriteLine("---------------MENU---------------");
                        Console.WriteLine("1 - Cadastrar cliente");
                        Console.WriteLine("2 - Criar pedido");
                        Console.WriteLine("3 - Receber pagamento");
                        Console.WriteLine("4 - Relatório dos pedidos criados");
                        Console.WriteLine("5 - Cancelar pedido");
                        Console.WriteLine("6 - Sair do sistema");
                        Console.Write("Selecione uma opção: ");
                        escolha = int.Parse(Console.ReadLine());
                    }
                    pagamento = formaPagamento;
                }

                if (escolha == 5)
                {
                    situacao = SituacoesEnum.Cancelado;
                    Console.WriteLine($"Pedido número: {codigo} está {SituacoesEnum.Cancelado}");

                    Console.WriteLine("---------------MENU---------------");
                    Console.WriteLine("1 - Cadastrar cliente");
                    Console.WriteLine("2 - Criar pedido");
                    Console.WriteLine("3 - Receber pagamento");
                    Console.WriteLine("4 - Relatório dos pedidos criados");
                    Console.WriteLine("5 - Cancelar pedido");
                    Console.WriteLine("6 - Sair do sistema");
                    Console.Write("Selecione uma opção: ");
                    escolha = int.Parse(Console.ReadLine());
                }
                if (escolha == 4)
                {
                    Console.WriteLine("---------------RELATÓRIO DOS PEDIDOS CRIADOS---------------");
                    Console.WriteLine($"Pedido {codigo}  Cliente: {lista.Cliente}  Valor total:  {total:F2} Data do pedido: {dataPedido}");
                    Console.WriteLine($"Forma de pagamento: À Vista");
                    Console.WriteLine("Itens");
                    Console.WriteLine($"Descrição: {Pedido.Descricao}");
                    Console.WriteLine($"Valor Unitário: {Pedido.ValorUnitario}");
                    Console.WriteLine($"Quantidade: {Pedido.Quantidade}");
                    Console.WriteLine("----------------------------------------------------------");
                
                    Console.WriteLine($"Pedido {codigo}  Cliente: {lista.Cliente}  Valor total:  {total:F2} Data do pedido: {dataPedido}");
                    Console.WriteLine($"Forma de pagamento: À Prazo");
                    Console.WriteLine($"Valor da Parcela: {valorTotal:F2}");
                    Console.WriteLine($"Parcela: {qtdParcelas}");
                    Console.WriteLine($"Data Vencimento: {dataPedido}");
                    Console.WriteLine($"Itens");
                    Console.WriteLine($"Descrição: {Pedido.Descricao}");
                    Console.WriteLine($"Valor Unitário: {Pedido.ValorUnitario}");
                    Console.WriteLine($"Quantidade: {Pedido.Quantidade}");
                }
            }
            if (escolha == 6)
            {
                Console.ReadKey();
            }
        }
    }
}