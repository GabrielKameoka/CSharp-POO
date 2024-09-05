namespace Projeto2_5;
class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Animal(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    public void Apresentar()
    {
        Console.WriteLine($"Olá, sou um animal, meu nome é {Nome} e tenho {Idade} anos. Sim, eu falo.");
    }
}