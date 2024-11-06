using System;
using System.Collections.Generic;
using Livraria.Utils;

namespace Livraria.Services
{
    public class MenuService
    {
        private EstoqueService estoqueService = new EstoqueService();

        public void ExibirMenu()
        {
            bool run = true;

            var menuActions = new Dictionary<string, Action>
            {
                { "1", CadastrarProduto },
                { "2", ListarProdutos },
                { "3", RemoverProduto },
                { "4", AdicionarEstoque },
                { "5", RetirarEstoque },
                { "0", SairDoSistema }
            };

            while (run)
            {
                ConsoleHelper.ExibirOpcoesMenu();
                string response = Console.ReadLine() ?? string.Empty;

                if (menuActions.ContainsKey(response))
                {
                    menuActions[response]();
                }
                else
                {
                    Console.WriteLine("Opção inválida! Tente novamente.");
                }
            }
        }

        private void CadastrarProduto()
        {
            string nome = LerEntradaTexto("Digite o nome do produto: ");
            int preco = LerEntradaInteiro("Informe o preço: ");
            string genero = LerEntradaTexto("Informe o gênero: ");
            string autor = LerEntradaTexto("Informe o nome do autor: ");

            estoqueService.AdicionarProduto(nome, preco, genero, quantidade: 0, autor);
            Console.WriteLine("Produto cadastrado com sucesso!");
        }

        private void ListarProdutos()
        {
            estoqueService.ListarProdutos();
        }

        private void RemoverProduto()
        {
            int id = LerEntradaInteiro("Digite o ID do produto: ");
            estoqueService.RemoverProduto(id);
            Console.WriteLine("Produto removido com sucesso!");
        }

        private void AdicionarEstoque()
        {
            int id = LerEntradaInteiro("Digite o ID do produto: ");
            int quantidade = LerEntradaInteiro("Digite a quantidade: ");
            estoqueService.EntradaEstoque(id, quantidade);
            Console.WriteLine("Estoque atualizado com sucesso!");
        }

        private void RetirarEstoque()
        {
            int id = LerEntradaInteiro("Digite o ID do produto: ");
            int quantidade = LerEntradaInteiro("Digite a quantidade: ");
            estoqueService.SaidaEstoque(id, quantidade);
            Console.WriteLine("Saída de estoque registrada com sucesso!");
        }

        private void SairDoSistema()
        {
            Console.WriteLine("Saindo do sistema...");
            Environment.Exit(0);
        }

        private string LerEntradaTexto(string mensagem)
        {
            Console.Write(mensagem);
            string? input = Console.ReadLine();

            while (!ValidationHelper.IsString(input))
            {
                Console.WriteLine("Entrada inválida. Tente novamente.");
                Console.Write(mensagem);
                input = Console.ReadLine();
            }

            return input!;
        }

        private int LerEntradaInteiro(string mensagem)
        {
            Console.Write(mensagem);
            string? input = Console.ReadLine();
            int result;

            while (!int.TryParse(input, out result))
            {
                Console.WriteLine("Entrada inválida. Digite um número válido.");
                Console.Write(mensagem);
                input = Console.ReadLine();
            }

            return result;
        }
    }
}
