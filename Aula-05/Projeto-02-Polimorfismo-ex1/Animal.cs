namespace Projeto2_5;
public class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Animal(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    public virtual void Apresentar()//Podem ser sobreescrito (virtual)
    {
        Console.WriteLine($"Olá, sou um animal, meu nome é {Nome} e tenho {Idade} anos. Sim, eu falo.");
    }
}

public class Cachorro : Animal
{
    public bool Adestrado { get; set; }

    public Cachorro(string nome, int idade, bool adestrado) : base (nome, idade)
    {
        Adestrado = adestrado;
    }
    
    public override void Apresentar()//Método herdado de Animal para se adequar no contexto correto 
    {
        Console.Write($"Olá, sou um cachorro(a), meu nome é {Nome}, tenho {Idade} anos ");
        if (Adestrado == true)
        {
            System.Console.Write("e sou adestrado. ");
        }
        else
        {
            System.Console.Write("e não sou adestrado. ");
        }
        System.Console.Write("Sim, eu falo.");
    }
}