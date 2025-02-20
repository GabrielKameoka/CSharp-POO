using System;
using System.Collections.Generic;
using HashSet.Entities;

namespace HashSet;

class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa("Gabriel", 20);
        Pessoa p2 = new Pessoa("Gabriella", 19);
        
        HashSet<Pessoa> set = new HashSet<Pessoa>();
        set.Add(p1);
        set.Add(p2);
        set.Add(p1);

        foreach (var pessoas in set)
        {
            Console.WriteLine($"Nome: {pessoas.Nome}, Idade: {pessoas.Idade}");
        }

        if (set.Contains(p1))
        {
            Console.WriteLine($"A lista contèm {p1.Nome}");
        }
        
        
    }
}