using Livraria.Services;

namespace Livraria
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuService menuService = new MenuService();

            menuService.ExibirMenu();
        }
    }
}
