using System;
namespace Exercicio8_1
{
    class Program
    {
        static void Main (string[] args)
        {
            //Crie um programa que peça ao usuário para inserir sua nota em uma prova e imprima se ele foi aprovado ou reprovado (considerando que a nota mínima para aprovação é 7).
            Console.WriteLine("Insira a sua nota de matemática");
            double nota = double.Parse(Console.ReadLine());
            if (nota < 7)
            {
                Console.WriteLine("REPROVAADOO!!");
            }
            else
            {
                Console.WriteLine("Você passou");
            }
        }
    }
}