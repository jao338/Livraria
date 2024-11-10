namespace Livraria.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public int Paginas { get; set; }
        public string Genero { get; set; }
        public string Autor { get; set; }

        public Livro(int id, string nome, double preco, string genero, int quantidade, int paginas, string autor)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Genero = genero;
            Quantidade = quantidade;
            Paginas = paginas;
            Autor = autor;
        }
    }
}
    