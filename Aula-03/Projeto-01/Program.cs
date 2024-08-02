using System;
using System.Globalization;
namespace Projeto1_3
{
    class Program
    {
        static void Main (string[] args)
        {

            Produto p = new Produto ("TV", 500, 10);

            p.Nome = "TV 4K";


            Console.WriteLine (p.Nome);
            Console.WriteLine (p.Preco);
            Console.WriteLine (p.Quantidade);

            Console.WriteLine ("Entre qualquer tecla para sair");
            Console.ReadLine ();

        }
    }
}