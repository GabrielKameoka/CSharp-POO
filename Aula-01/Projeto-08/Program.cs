using System;
using System.Globalization;

namespace Aula01 {
    class Program {
        static void Main (string[] args) {

            // int a = 10;
            // bool c1 = a < 10;
            // bool c2 = a < 20;
            // bool c3 = a > 10;
            // bool c4 = a > 9;
            // bool c5 = a <= 10;

            // System.Console.WriteLine(c1);
            // System.Console.WriteLine(c2);
            // System.Console.WriteLine(c3);
            // System.Console.WriteLine(c4);
            // System.Console.WriteLine(c5);
            // System.Console.WriteLine("---------//----------");

            bool c1 = 2 > 3 && 4 != 5;
            System.Console.WriteLine(c1); //se ambos forem verdadeiras, a saída vai ser verdadeira

            bool c2 = 2 > 3 || 4 != 5;
            System.Console.WriteLine(c2); //se pelo menos uma for verdadeira, a sáida vai ser verdadeira

            bool c3 = 10 < 5;
            bool c4 = c1 || c2 && c3;

        }
    }
} 