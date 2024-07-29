using System;
namespace Exercicio4_2
{
    class Program
    {
        static void Main (string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            r.largura = double.Parse(Console.ReadLine());
            r.altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Área = " + r.CalculaArea().ToString());
            Console.WriteLine("Perímetro = " + r.CalculaPerimetro().ToString());
            Console.WriteLine("Diagonal = " + r.CalculaDiagonal().ToString() );

            Console.WriteLine("Entre qualquer tecla para sair");
            Console.ReadLine();
        }
    }
}