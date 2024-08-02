using System;
namespace Exercicio1_3
{
    class Program
    {
        static void Main (string[] args)
        {
               
            string nome = Console.ReadLine ();
            int idade = int.Parse (Console.ReadLine ());
            double altura = double.Parse (Console.ReadLine ());
            
            Pessoa p = new Pessoa(nome, idade, altura);

            Console.WriteLine(p.Apresentar());

            Console.ReadLine ();
        }
    }
}