namespace SortedSet.Entities;

public class Gato : Animal
{
    public string Raca { get; set; }
    
    public Gato(string nome, int idade, string raca) : base(nome, idade)
    {
        Raca = raca;
    }
}