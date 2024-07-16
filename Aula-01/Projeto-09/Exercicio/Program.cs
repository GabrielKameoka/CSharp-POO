using System;

namespace Aula01 {
    class Program { 
        static void Main (string[] args) {

            System.Console.WriteLine("Exercício 1");
            int ex1 = int.Parse (Console.ReadLine());

            if (ex1 < 0) {
                System.Console.WriteLine("Negativo");
            } else {
                System.Console.WriteLine("Positivo");
            }


            System.Console.WriteLine("Exercício 2");
            int ex2 = int.Parse (Console.ReadLine());

            if (ex2 % 2 == 0) {
                System.Console.WriteLine("Par");
            } else {
                System.Console.WriteLine("Impar");
            }


            System.Console.WriteLine("Exercício 3");



        }
    }
}