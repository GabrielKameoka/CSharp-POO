using System;

namespace Exercicio6_1 {
    class Program
    {
        static void Main (string[] args) {
            //Crie um programa que peça ao usuário para inserir dois números e verifique se o primeiro número é divisível pelo segundo.

            Console.WriteLine("Digite 2 números");
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());

            if (A % B == 0) {
                Console.WriteLine("O primeiro número é digivisível pelo segundo número");
            }
            else {
                Console.WriteLine("O primeiro número não é divisível pelo segundo número");
            }
        }
    }
}