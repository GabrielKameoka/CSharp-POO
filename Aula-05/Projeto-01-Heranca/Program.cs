using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.CompilerServices;
namespace Heranca;
class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine ("É cachorro(a) ou gato(a)?");
        string x = Console.ReadLine ();
        if (x == "cachorro")
        {
            Dog meuCachorro = new Dog ();

            Console.Write ("Digite o nome do seu(a) cachorro(a): ");
            meuCachorro.Name = Console.ReadLine ();
            Console.Write ("Digite a idade do seu(a) cachorro(a): ");
            meuCachorro.Age = int.Parse (Console.ReadLine ());
            Console.Write ("Digite quantos dentes o seu(a) cachorro(a) tem: ");
            meuCachorro.Teeth = int.Parse (Console.ReadLine ());

            meuCachorro.Apresentar ();
        }
        else if (x == "gato")
        {
            Cat meuGato = new Cat ();

            Console.Write ("Digite o nome do seu(a) gato(a): ");
            meuGato.Name = Console.ReadLine ();
            Console.Write ("Digite a idade do seu(a) gato(a): ");
            meuGato.Age = int.Parse (Console.ReadLine ());
            Console.Write ("Digite quantas garras o seu(a) gato(a) tem: ");
            meuGato.Claw = int.Parse (Console.ReadLine ());

            meuGato.Apresentar ();
        }

        Console.ReadLine ();
    }
}