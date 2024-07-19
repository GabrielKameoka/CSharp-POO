using System;

namespace Exercicio {
    class Program {
        static void Main(string[] args) {
            
            double renda = double.Parse(Console.ReadLine());
            
            if (renda <= 2000) {

                System.Console.WriteLine("Isento");

            } else if (renda >= 2000.1 && renda <= 3000) {
                
                double imposto1 = (renda - 2000);
                double resultado1 = imposto1 * 0.08;
                System.Console.WriteLine(resultado1);

            } else if (renda >= 3000.1 && renda <= 4500) {

                double impostoisento = renda - 2000;
                double imposto2 = 1000 * 0.08;
                double impostosobre1 = impostoisento - 1000;
                double impostosobre2 = impostosobre1 * 0.18;
                double resultado2 = imposto2 + impostosobre2;
                System.Console.WriteLine($"R${resultado2}");
            }
        }
    }
}