using System;
namespace Exercicio6_3;
class Program
{
    static List<ContaBancaria> clientes = new List<ContaBancaria>();
    static void Main(string[] args)
    {
        System.Console.WriteLine("Quantas pessoas vão ser?");
        int numeroPessoas = int.Parse(Console.ReadLine());
        for(int i = 0; i < numeroPessoas; i++)
        {
            ContaBancaria p = new ContaBancaria();

            System.Console.WriteLine();
            System.Console.Write($"Escreva o nome da {i + 1}°: ");
            p.Titular = Console.ReadLine();
            System.Console.Write("Digite o saldo inicial: ");
            p.Saldo = double.Parse(Console.ReadLine());
            System.Console.Write("Digite o número desejado para a conta(21): ");
            p.Numero = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            clientes.Add(p);

            System.Console.WriteLine($"A conta com número {p.Numero} do sr(a) {p.Titular} com {p.Saldo} foi criado.");
            System.Console.WriteLine();
        }

        foreach(ContaBancaria cliente in clientes)
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"Nome do titular: {cliente.Titular}");
            System.Console.WriteLine($"Saldo do titular: {cliente.Saldo}");
            System.Console.WriteLine($"Número do titular: {cliente.Numero}");
            System.Console.WriteLine();
        }
    }
}