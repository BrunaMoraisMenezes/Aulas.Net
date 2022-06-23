using System;
using System.Collections.Generic;
using System.IO;

namespace Arquivo
{
    class Arquivo : IArquivo
    {
        public string Endereco { get; set; }
        public List<Funcionario> Funcionarios = new List<Funcionario>();

        public Arquivo(string endereco)
        {
            Endereco = endereco;
            Funcionarios = new List<Funcionario>();
        }

        public List<string> ListaDiretorios()
        {
            Console.WriteLine("****************** Arquivos do Diretório ********************");
            List<string> arquivos = new List<string>();
            var arquivosDiretorios = Directory.EnumerateFiles(Endereco);
            foreach (var arquivo in arquivosDiretorios)
            {
                arquivos.Add(Path.GetFileName(arquivo));
                Console.WriteLine(arquivo);
            }
            Console.WriteLine("*************************************************************");
            return arquivos;
        }

        public List<Funcionario> ListaFuncionarios()
        {
            Console.WriteLine("****************** Dados Funcionário ********************");

            IEnumerable<string> arquivosExtensao = Directory.EnumerateFiles(Endereco, "*.IBMDOTNET");

            foreach (string arquivo in arquivosExtensao)
            {
                try
                {
                    using (StreamReader sr = File.OpenText(arquivo))
                    {
                        sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            var linhaArquivo = sr.ReadLine().Split(";");
                            Funcionarios.Add(new Funcionario() { Id = int.Parse(linhaArquivo[0]), NomeCompleto = linhaArquivo[1], DataNascimento = DateTime.Parse(linhaArquivo[2]), Salario = Decimal.Parse(linhaArquivo[3]) });
                        }
                    }
                    MoverArquivoSucesso(arquivo);
                }

                catch (FormatException exception)
                {
                    MoverArquivoErro(arquivo);
                    Console.WriteLine("Arquivo movido para a pasta Erro " + exception.Message);
                }
            }
            Console.WriteLine("Id " + " Nome " + " Data de Nascimento " + " Salario ");
            foreach (Funcionario funcionario in Funcionarios)
            {
                Console.WriteLine(funcionario);
            }
            Console.WriteLine("*************************************************************");
            return Funcionarios;
        }

        public void MoverArquivoSucesso(string endereco)
        {
            string nome = Path.GetFileName(endereco);
            string processado = @$"{Endereco}\Processado\{nome}";
            File.Move(endereco, processado);
            Console.WriteLine("Arquivo movido para a pasta Processado");
        }

        public void MoverArquivoErro(string endereco)
        {
            string nome = Path.GetFileName(endereco);
            string erro = @$"{Endereco}\Erro\{nome}";
            File.Move(endereco, erro);
            Console.WriteLine("Arquivo movido para a pasta Erro");
        }
    }
}

