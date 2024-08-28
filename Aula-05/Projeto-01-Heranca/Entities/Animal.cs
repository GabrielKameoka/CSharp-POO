using System;
namespace Herancas.Entities;
class Animal
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    public Animal()
    {
        
    }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Eat()
    {
        Console.WriteLine("Comendo...");
    }

    public void Sleep()
    {
        Console.WriteLine("Dormindo...");
    }
}