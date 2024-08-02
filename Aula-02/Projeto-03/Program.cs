using System;
using System.Globalization;
namespace Projeto3_2
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());
            double circ = Calculadora.Circunferencia(raio);
            double vol = Calculadora.Volume(raio);

            Console.WriteLine("Curcunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));


            Console.WriteLine();
            Console.WriteLine("Entre com qualque tecla para sair");
            Console.ReadLine();
        }
        
    }
}