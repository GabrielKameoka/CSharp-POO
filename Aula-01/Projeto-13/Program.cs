using System;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.Write("Quantos números inteiros você vai digitar?");
            int N = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= N; i++)
            {
                System.Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma = soma + valor;
            }
            System.Console.WriteLine("soma = " + soma);

        }
    }
}