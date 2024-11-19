using System;
using System.Collections.Generic;
using Livraria.Models;

namespace Livraria.Services
{
    public class EstoqueService
    {
        private List<Livro> livros = new List<Livro>();

        private int nextId = 1;

        public void AdicionarProduto(string nome, double preco, string genero, int quantidade, int paginas, string autor){
            Livro livro = new Livro(nextId++, nome, preco, genero, quantidade, paginas, autor);

            livros.Add(livro);
        }

        public void RemoverProduto(int id)
        {
            Livro livro = livros.Find(p => p.Id == id);
            if (livro != null){

                livros.Remove(livro);

                Console.WriteLine("Livro removido com sucesso!");
            }else{
                Console.WriteLine("Livro não encontrado!");
            }
        }
        
        public void SaidaEstoque(int id, int quantidade){
            Livro livro = livros.Find(p => p.Id == id);
            if (livro != null){
                if (livro.Quantidade > quantidade){
                    livro.Quantidade -= quantidade;
                    Console.WriteLine("Saída no estoque realizada com sucesso!");
                }else{
                    Console.WriteLine("Quantidade insuficiente no estoque!");
                }
            }else{
                Console.WriteLine("Produto não encontrado!");
            }
        }

        public void EntradaEstoque(int id, int quantidade)
        {
            Livro livro = livros.Find(p => p.Id == id);
            if (livro != null){
                livro.Quantidade += quantidade;
                Console.WriteLine("Entrada no estoque realizada com sucesso!");
            }else{
                Console.WriteLine("Produto não encontrado!");
            }
        }

        public void ListarProdutos()
        {
            if (livros.Count == 0){
                Console.WriteLine("Nenhum produto cadastrado.");
                return;
            }else{
                foreach (var livro in livros){
                    Console.WriteLine($"ID: {livro.Id}, Nome: {livro.Nome}, Gênero: {livro.Genero}, Preço: {livro.Preco}, Quantidade: {livro.Quantidade}");
                }
            }
        }
    }
}
