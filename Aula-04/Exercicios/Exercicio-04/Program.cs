/*
Crie um programa em C# que:

Peça ao usuário para inserir 5 números inteiros.
Armazene esses números em um array.
Calcule a média desses números.
Exiba a média na tela.
*/

using System;
using System.Globalization;
namespace Exercicio4_4;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Entre com 5 números inteiros");
        //Cria o array
        int [] vect = new int[5];

        //percorre o array
        for (int i = 0; i < vect.Length; i++)
        {
            System.Console.WriteLine($"Digite o {i + 1}º número");
            vect[i] = int.Parse(Console.ReadLine());
        }

        //faz a soma e calcula a média
        double soma = 0;
        for (int i = 0; i < 5; i++)
        {
            soma += vect[i];
        }
        double avg = soma / vect.Length;
        System.Console.WriteLine($"A média dos números entrados é de : {avg.ToString("F2",CultureInfo.InvariantCulture)}");
    }
}