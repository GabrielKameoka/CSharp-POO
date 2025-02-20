using System;
using Exercicio1;


namespace Exercicio1GetHashCodeEquals;

class Program
{
    static void Main(string[] args)
    {
        Produto produto1 = new Produto("Camiseta", 29.99m, "Vestuário");
        Produto produto2 = new Produto("Camiseta", 29.99m, "Vestuário");
        Produto produto3 = new Produto("Calça", 59.99m, "Vestuário");

        Console.WriteLine(produto1.Equals(produto2)); // true
        Console.WriteLine(produto1.Equals(produto3)); // false

        HashSet<Produto> produtos = new HashSet<Produto>();
        produtos.Add(produto1);
        produtos.Add(produto2); // Não será adicionado, pois produto2 é igual a produto1
        produtos.Add(produto3);

        Console.WriteLine(produtos.Count); // 2
    }
}