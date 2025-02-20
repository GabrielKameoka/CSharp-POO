using System;
using GetHashCodeEquals.Entities;

namespace GetHashCodeEquals;

class Program
{
    static void Main(string[] args)
    {
        Client a = new Client{Name = "Gabi", Email = "gabi@gmail.com"};
        Client b = new Client{Name = "Maisa", Email = "gabi@gmail.com"};

        Console.WriteLine(a.Equals(b));
        Console.WriteLine(a == b);
        Console.WriteLine(a.GetHashCode());
        Console.WriteLine(b.GetHashCode());
        
    }
}