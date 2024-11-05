namespace ControleEstoque.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Preco { get; set; }
        public int Genero { get; set; }

        public Produto(int id, string nome, int preço, int genero)
        {
            Id = id;
            Nome = nome;
            Preco = preço;
            Genero = genero;
        }
    }
}
