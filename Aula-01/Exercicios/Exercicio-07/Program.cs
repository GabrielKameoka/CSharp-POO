using System;
namespace Exercicio7_1
{
    class Program
    {
        static void Main (string[] args)
        {
            //Crie um programa que peça ao usuário para inserir uma temperatura e verifique se está frio, agradável ou quente.

            Console.WriteLine("Insira a temperatuda do seu ambiente");
            int A = int.Parse (Console.ReadLine());
            int fria = 15;
            int agradavel = 30;


            if (A <= fria)
            {
                Console.WriteLine("A temperatura está fria");
            }
            else if (A > fria && A <= agradavel)
            {
                Console.WriteLine("A temperatura está agradável");
            }
            else
            {
                Console.WriteLine("A temperatura está quente");
            }
        }
    }
}