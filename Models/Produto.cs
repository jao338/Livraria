namespace Livraria.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Preco { get; set; }
        public int Quantidade { get; set; }
        public string Genero { get; set; }

        public Produto(int id, string nome, int preco, string genero, int quantidade)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Genero = genero;
            Quantidade = quantidade;
        }
    }
}
    