using System;
using System.Collections.Generic;

namespace Aulas_Net
{
    class Atividade_UrnaEletronica
    {
        static void xMain(string[] args)
        {
            var primeiroCandidato = new Candidatos() { Nome = "Candidato Jair Rodrigues" };
            var segundoCandidato = new Candidatos() { Nome = "Candidato Carlos Luz" };
            var terceiroCandidato = new Candidatos() { Nome = "Candidato Neves Rocha" };

            var listaCandidatos = new List<Candidatos>();
            listaCandidatos.Add(primeiroCandidato);
            listaCandidatos.Add(segundoCandidato);
            listaCandidatos.Add(terceiroCandidato);

            int i = 1;

            Console.WriteLine("-------- OPÇÕES --------");
            foreach (var candidatos in listaCandidatos)
            {
                Console.WriteLine(i + ". {0}", candidatos.Nome);
                i++;
            }

            Console.WriteLine("4. Nulo");
            Console.WriteLine("5. Branco");
            Console.Write("Digite sua escolha:");
            int escolha = int.Parse(Console.ReadLine());

            int votosCandidato1 = 0, votosCandidato2 = 0, votosCandidato3 = 0, votosNulos = 0, votosBrancos = 0;

            switch (escolha)
            {
                case 1:
                    votosCandidato1++;
                    break;
                case 2:
                    votosCandidato2++;
                    break;
                case 3:
                    votosCandidato3++;
                    break;
                case 4:
                    votosNulos++;
                    break;
                case 5:
                    votosBrancos++;
                    break;
                default:
                    Console.WriteLine("OPÇÃO INVÁLIDA!");
                    break;
            }

            do
            {
                Console.Write("Digite sua escolha:");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        votosCandidato1++;
                        break;
                    case 2:
                        votosCandidato2++;
                        break;
                    case 3:
                        votosCandidato3++;
                        break;
                    case 4:
                        votosNulos++;
                        break;
                    case 5:
                        votosBrancos++;
                        break;
                    default:
                        Console.WriteLine("OPÇÃO INVÁLIDA!");
                        break;
                }

            } while (escolha != 6);

            Console.WriteLine("-------- QUANTIDADE DE VOTOS PARA CADA CANDIDATO --------");
            Console.WriteLine("Candidato Jair Rodrigues: {0}", votosCandidato1, "votos");
            Console.WriteLine("Candidato Carlos Luz: {0}", votosCandidato2, "votos");
            Console.WriteLine("Candidato Neves Rocha: {0}", votosCandidato3, "votos");

            double totalVotos = (votosCandidato1 + votosCandidato2 + votosCandidato3 + votosNulos + votosBrancos);

            Console.WriteLine("-------- PORCENTAGEM DE VOTOS NULOS --------");
            double totalNulos = (votosNulos / totalVotos) * 100;
            Console.WriteLine(totalNulos.ToString("F2") + "%");

            Console.WriteLine("-------- PORCENTAGEM DE VOTOS BRANCOS --------");
            double totalBrancos = (votosBrancos / totalVotos) * 100;
            Console.WriteLine(totalBrancos.ToString("F2") + "%");

            Console.WriteLine("-------- CANDIDATO VENCEDOR --------");
            if (votosCandidato1 > votosCandidato2 && votosCandidato1 > votosCandidato3)
                Console.WriteLine("Candidato Jair Rodrigues");
            else if (votosCandidato2 > votosCandidato1 && votosCandidato2 > votosCandidato3)
                Console.WriteLine("Candidato Carlos Luz");
            else
                Console.WriteLine("Candidato Neves Rocha");
        }
    }
}
