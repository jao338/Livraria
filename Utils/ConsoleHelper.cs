namespace Livraria.Utils
{
    public static class ConsoleHelper
    {
        public static void ExibirOpcoesMenu()
        {
            Console.WriteLine("\nSelecione uma opção:");
            Console.WriteLine("[1] Novo");
            Console.WriteLine("[2] Listar Produtos");
            Console.WriteLine("[3] Remover Produtos");
            Console.WriteLine("[4] Entrada Estoque");
            Console.WriteLine("[5] Saída Estoque");
            Console.WriteLine("[0] Sair");
            Console.Write("Opção: ");
        }
    }
}
