using System;
namespace Exercicio2_3
{
    class Program
    {
        static void Main (string[] args)
        {
            Produto produto1 = new Produto ();
            produto1.GetNome ();

            Produto produto2 = new Produto ("Celular", 1500);
            produto2.SetNome ("tv");

            Produto produto3 = new Produto ("Livro", 50, 20);
            produto3.MostrarDetalhes ();

            Console.ReadLine ();
        }
    }
}