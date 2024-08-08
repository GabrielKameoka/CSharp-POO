using System;
using System.Globalization;
namespace Exercicio2_4;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("São quantas pessoas?");
        int n = int.Parse(Console.ReadLine());

        double[] vect = new double[n];

        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine($"digite a altura da pessoa {i + 1}");
            vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        double soma = 0;
        for (int i = 0; i < n; i++){
            soma += vect[i];
        }
        double avg = soma / n;
        System.Console.WriteLine("AVERAGE HEIGTH: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        Console.ReadLine();
    }
}