namespace SortedSet.Entities;

public class Cachorro : Animal
{
    public string Raca { get; set; }
    
    public Cachorro(string nome, int idade, string raca) : base(nome, idade)
    {
        Raca = raca;
    }
}