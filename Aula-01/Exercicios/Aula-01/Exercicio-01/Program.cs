using System;
using System.Globalization;

namespace Exercicio {
    class Program {
        static void Main(string[] args) {
            
            int A = int.Parse (Console.ReadLine());
            int B = int.Parse (Console.ReadLine());

            if (A % B == 0 || B % A == 0){ 
                System.Console.WriteLine("São múltiplos");
            } else {
                System.Console.WriteLine("Não são múltiplos");
            }
            
        }
    }
}