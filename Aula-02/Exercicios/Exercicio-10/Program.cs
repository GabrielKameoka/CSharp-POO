using System;

namespace Exercicio10_2
{
    class Program
    {
        static void Main (string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.Write("Digite o ângulo do triângulo retangulo: ");
            calc.Angulo = double.Parse (Console.ReadLine());

            double anguloRadianos = calc.Angulo * Math.PI / 180;

            Console.WriteLine(anguloRadianos);
            double seno = Math.Sin (anguloRadianos);
            double cosseno = Math.Cos (anguloRadianos);
            double tangente = Math.Tan (anguloRadianos);

            Console.WriteLine ($"Seno: {seno:F4}");
            Console.WriteLine ($"Cosseno: {cosseno:F4}");
            Console.WriteLine ($"Tangente: {tangente:F4}");

            Console.ReadLine();
        }
    }
}