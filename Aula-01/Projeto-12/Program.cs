using System;
using System.Globalization;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.Write("Digite um número: ");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (n1 >= 0)
            {
                double n1Raiz = n1 * n1;
                System.Console.WriteLine(n1Raiz.ToString("F1", CultureInfo.InvariantCulture));
                System.Console.WriteLine("Digite outro número: ");
                n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            System.Console.WriteLine("Número negativo");

        }
    }
}