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

                        if (!ValidationHelper.IsString(consoleName))
                        {
                            Console.WriteLine("Nome inválido. Tente novamente.");
                            continue;
                        }

                        nome = consoleName;

                        Console.Write("Informe o preço: ");
                        string consoleValue = Console.ReadLine();

                        if (!ValidationHelper.IsNumeric(consoleValue))
                        {
                            Console.WriteLine("Valor inválido. Tente novamente.");
                            continue;
                        }

                        preco = int.Parse(consoleValue);

                        Console.Write("Informe o gênero: ");
                        string consoleGender = Console.ReadLine();

                        if (!ValidationHelper.IsString(consoleGender))
                        {
                            Console.WriteLine("Nome inválido. Tente novamente.");
                            continue;
                        }
                        genero = consoleGender;

                         Console.Write("Informe a quantidade: ");
                        string consoleQtd = Console.ReadLine();

                        if (!ValidationHelper.IsNumeric(consoleQtd))
                        {
                            Console.WriteLine("Valor inválido. Tente novamente.");
                            continue;
                        }

                        quantidade = int.Parse(consoleQtd);

                        estoqueService.Store(nome, preco, genero, quantidade);
                    break;

                    case "2":
                        estoqueService.Index();
                    break;

                    case "3":
                        Console.WriteLine("Remover produtos.");
                    break;

                    case "4":
                        Console.WriteLine("Entrada no estoque.");
                    break;

                    case "5":
                        Console.WriteLine("Saída do estoque.");
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
