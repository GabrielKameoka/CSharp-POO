using System;
using InterfaceIComparable.Entites;

namespace InterfaceIComparable;

class Program
{
    static void Main(string[] args)
    {
        List<Pessoa> pessoas = new List<Pessoa>();
        pessoas.Add(new Pessoa { Nome = "Alice", Idade = 30 });
        pessoas.Add(new Pessoa { Nome = "Bob", Idade = 25 });
        pessoas.Add(new Pessoa { Nome = "Charlie", Idade = 35 });
        
        pessoas.Sort();
        
        foreach (var index in pessoas)
        {
            Console.WriteLine($"Nome: {index.Nome}, idade: {index.Idade}");
        }
    }
}

