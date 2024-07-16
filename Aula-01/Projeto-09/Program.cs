using System;

namespace Aula01 {
    class Program {
        static void Main (string[] args) {

            System.Console.WriteLine("Entre com um númeto inteiro:");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) {
                System.Console.WriteLine("O número é par");
            } else {
                System.Console.WriteLine("O número é ímpar");
            }

        }
    }
}