using System;
using System.Globalization;

namespace Projeto1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*Fazer um programa para ler as medidas dos lados de dois triângulos X e Y (suponha medidas válidas). Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos possui a maior área.*/

            Triangulo x, y;

            x = new Triangulo(); //instanciando a classe para dois triangulos
            y = new Triangulo();

            System.Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areax = x.Area();

            double areay = y.Area();

            System.Console.WriteLine($"Área de x = {areax}");
            System.Console.WriteLine($"Área de x = {areay}");

            if (areay < areax)
            {
                System.Console.WriteLine("A área maior é o triangulo x");
            }
            else
            {
                System.Console.WriteLine("A área maior é o triangulo y");
            }
            


        }
    }
}