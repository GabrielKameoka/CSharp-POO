using System;

namespace Exercicio5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um algoritmo que leia os valores de A, B, C e em seguida imprima na tela a soma entre A e B é mostre se a soma é menor que C.*/

            System.Console.WriteLine("Digite 3 números");
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            double soma = A + B;
            System.Console.WriteLine($"A soma é: {soma}");
            if (soma > C)
            {
                System.Console.WriteLine("E a soma é maior que o terceiro número");
            }
            else
            {
                System.Console.WriteLine("E a soma é menor que o terceiro número");
            }

        }
    }
}