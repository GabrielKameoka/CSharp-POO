using System;

namespace Exercicio1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            System.Console.WriteLine("Dados da primeira pessoa");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Dados da segunda pessoa");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());
            
            if (p1.Idade < p2.Idade) {
                System.Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
            } else {
                System.Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
            }
        }
    }
}