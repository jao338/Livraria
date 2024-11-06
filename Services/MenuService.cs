using System;
using Livraria.Utils;

namespace Livraria.Services
{
    public class MenuService
    {
        private EstoqueService estoqueService = new EstoqueService();

        public void ExibirMenu()
        {
            bool run = true;
            string nome = string.Empty;
            int preco = 0;
            string genero = string.Empty;
            int quantidade = 0;
            string autor = string.Empty;

            while (run)
            {
                ConsoleHelper.ExibirOpcoesMenu();

                string? response = Console.ReadLine();

                switch (response)
                {
                    case null:
                        Console.WriteLine("Opção inválida! Tente novamente."); 
                    break;

                    case "1":
                        Console.Write("Digite o nome do produto: ");
                        string consoleName = Console.ReadLine();

                        if (!ValidationHelper.IsString(consoleName)){
                            Console.WriteLine("Nome inválido. Tente novamente.");
                            continue;
                        }

                        nome = consoleName;

                        Console.Write("Informe o preço: ");
                        string consoleValue = Console.ReadLine();

                        if (!ValidationHelper.IsNumeric(consoleValue)){
                            Console.WriteLine("Valor inválido. Tente novamente.");
                            continue;
                        }

                        preco = int.Parse(consoleValue);

                        Console.Write("Informe o gênero: ");
                        string consoleGender = Console.ReadLine();

                        if (!ValidationHelper.IsString(consoleGender)){
                            Console.WriteLine("Nome inválido. Tente novamente.");
                            continue;
                        }
                        genero = consoleGender;

                        Console.Write("Informe o nome do autor: ");
                        string consoleAutor = Console.ReadLine();

                        if (!ValidationHelper.IsString(consoleAutor)){
                            Console.WriteLine("Valor inválido. Tente novamente.");
                            continue;
                        }

                        autor = consoleAutor;

                        estoqueService.Store(nome, preco, genero, quantidade, autor);
                    break;

                    case "2":
                        estoqueService.Index();
                    break;

                    case "3":
                        Console.Write("Digite o ID do produto: ");
                        string idProduto = Console.ReadLine();

                        if (!ValidationHelper.IsNumeric(idProduto)){
                            Console.WriteLine("Valor inválido. Tente novamente.");
                            continue;
                        }

                        estoqueService.RemoverProduto(int.Parse(idProduto));

                    break;

                    case "4":
                        Console.Write("Digite o ID do produto:");
                        string idEntrada = Console.ReadLine();

                        if (!ValidationHelper.IsNumeric(idEntrada)){
                            Console.WriteLine("Valor inválido. Tente novamente.");
                            continue;
                        }

                        Console.Write("Digite a quantidade: ");
                        string QtdEntrada = Console.ReadLine();

                        if (!ValidationHelper.IsNumeric(QtdEntrada)){
                            Console.WriteLine("Valor inválido. Tente novamente.");
                            continue;
                        }

                        estoqueService.EntradaEstoque(int.Parse(idEntrada), int.Parse(QtdEntrada));

                    break;

                    case "5":
                        Console.Write("Digite o ID do produto: ");
                        string idSaida = Console.ReadLine();

                        if (!ValidationHelper.IsNumeric(idSaida)){
                            Console.WriteLine("Valor inválido. Tente novamente.");
                            continue;
                        }

                        Console.Write("Digite o ID do produto: ");
                        string QtdSaida = Console.ReadLine();

                        if (!ValidationHelper.IsNumeric(QtdSaida)){
                            Console.WriteLine("Valor inválido. Tente novamente.");
                            continue;
                        }

                        estoqueService.SaidaEstoque(int.Parse(idSaida), int.Parse(QtdSaida));
                    break;

                    case "0":
                        run = false;
                        Console.WriteLine("Saindo do sistema...");
                    break;

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
                }
            }
        }
    }
}
