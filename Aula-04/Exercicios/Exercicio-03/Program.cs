/*
Peça ao usuário para inserir 5 números inteiros.
Armazene esses números em um array.
Calcule a média desses números.
Exiba a média na tela.
*/

using System;
using System.Globalization;
namespace Exercicio3_4;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Insira quantidade de números inteiros: ");
        int quantidade = int.Parse(Console.ReadLine());
        int[] numeros = new int[quantidade];

        for (int i = 0; i < quantidade; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        double soma = 0.0;
        foreach (int n in numeros)
        {
            soma += n;
        }
        double media = soma / quantidade;

        System.Console.WriteLine($"A média dos números é {media}");
    }
}