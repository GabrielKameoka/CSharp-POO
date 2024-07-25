using System;

namespace Exercicio2_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            System.Console.WriteLine("Dados da primeira pessoa:");
            System.Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            System.Console.Write("Salário da primeira pessoa:");
            p1.Salario = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Dados da primeira pessoa:");
            System.Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            System.Console.Write("Salário da primeira pessoa:");
            p2.Salario = double.Parse(Console.ReadLine());

            double SalarioMedio = (p1.Salario + p2.Salario) / 2;

            System.Console.WriteLine($"Salário mèdio: {SalarioMedio}");

        }
    }
}