namespace Livraria.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Preco { get; set; }
        public int Quantidade { get; set; }
        public string Genero { get; set; }
        public string Autor { get; set; }

        public Livro(int id, string nome, int preco, string genero, int quantidade, string autor)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Genero = genero;
            Quantidade = quantidade;
            Autor = autor;
        }
    }
}
    