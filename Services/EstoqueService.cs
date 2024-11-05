using System;
using System.Collections.Generic;
using Livraria.Models;

namespace Livraria.Services
{
    public class EstoqueService
    {
        private List<Produto> produtos = new List<Produto>();

        private int nextId = 1;

        public void Store(string nome, int preco, string genero, int quantidade)
        {
            Produto produto = new Produto(nextId++, nome, preco, genero, quantidade);

            produtos.Add(produto);

            Console.WriteLine("Produto adicionado com sucesso!");
        }

        public void Index()
        {

            if (produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
                return;
            }
            
           foreach (var produto in produtos)
            {
                Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Gênero: {produto.Genero}, Preço: {produto.Preco}, Quantidade: {produto.Quantidade}");
            }
        }

    }
}
