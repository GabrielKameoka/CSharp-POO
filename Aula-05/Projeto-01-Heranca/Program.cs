using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
namespace Heranca;
class Program
{
    static void Main(string[] args)
    {
        Dog meuCachorro = new Dog();

        Console.Write("Digite o nome do seu(a) cachorro(a): ");
        meuCachorro.Name = Console.ReadLine ();
        Console.Write("Digite a idade do seu(a) cachorro(a): ");
        meuCachorro.Age = int.Parse(Console.ReadLine());
        Console.Write("Digite quantos dentes o seu(a) cachorro(a) tem: ");
        meuCachorro.Teeth = int.Parse(Console.ReadLine());

        meuCachorro.Apresentar ();

        Console.ReadLine ();
    }
}