using System;
namespace Projeto3_5
public class Biblioteca
{
    public string Nome { get; set; }

    public virtual void Apresentar ()
    {
        Console.WriteLine ($"{Nome}.");
    }
}

public class Caderno : Biblioteca
{
    public int NumeroPaginas { get; set; }

    public override void Apresentar ()
    {
        Console.WriteLine ($"{Nome} tem {NumeroPaginas}.");
    }
}

public class Livro : Biblioteca
{
    public string Autor { get; set; }

    public override void Apresentar ()
    {
        Console.WriteLine ($"{Nome} é do autor {Autor}.");
    }
}