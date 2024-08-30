namespace Heranca;

public class Animal //Declarando uma classe base(superclasse)
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal ()
    {
    
    }

    public Animal (string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void Apresentar () // Método virtual para ser sobrescrito em classes derivadas
    {
        Console.WriteLine ($"O animal {Name} tem {Age} anos.");
    }
}

public class Dog : Animal //Herdando da classe base "Animal"
{
    public int Teeth{ get; set; }

    public Dog ()
    {
    
    }

    public Dog (string name, int age, int teeth)  : base (name, age) //herdando os construtores da classe base "Animal"
    {
        Teeth = teeth;
    }

    public void Bark ()
    {
        Console.WriteLine ("Au au!!");
    }

    public override void Apresentar () //Sobrescrever o método da classe base
    {
        Console.WriteLine ();
        Console.WriteLine ($"O(a) cachorro(a) '{Name}' está com {Age} anos de idade e tem {Teeth} dentes.");
    }
}