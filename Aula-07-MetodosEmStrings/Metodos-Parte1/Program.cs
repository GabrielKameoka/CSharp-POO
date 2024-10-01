using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
namespace Projeto1_7_parte1;
class Program
{
    static void Main (string[] args)
    {

        string original = "meu nome é Julia!!!          ";
        Console.WriteLine($"A string original é: {original}");

        Console.WriteLine();

        Console.WriteLine("Método ToUpper:");
        string ToUpper = original.ToUpper ();
        Console.WriteLine(ToUpper);

        Console.WriteLine();

        Console.WriteLine("Método ToLower");
        string ToLower = original.ToLower ();
        Console.WriteLine(ToLower);


        Console.WriteLine();

        Console.WriteLine("Método substring a partir da posição 6:");
        string Substring = original.Substring (6);
        Console.WriteLine(Substring);

        Console.WriteLine();

        Console.WriteLine ("Método substring a partir da posição 10 e mostrando 5 letras depois de 10:");
        string Substring2 = original.Substring (10, 6);
        Console.WriteLine (Substring2);

        Console.WriteLine();

        Console.WriteLine("Método replace trocando os caracteres 'e' para 'b': ");
        string replace = original.Replace ("e", "b");
        Console.WriteLine(replace);

        Console.WriteLine();

        Console.WriteLine ("Método replace trocando o nome 'Julia' para 'Gabriel': ");
        string replace2 = original.Replace ("Julia", "Gabriel");
        Console.WriteLine (replace2);

        Console.WriteLine();

        Console.WriteLine("Método NullOrEmpty(verifica se a string é nula ou vazia): ");
        bool NullOrEmpty = string.IsNullOrEmpty (original);
        Console.WriteLine(NullOrEmpty);

        Console.WriteLine();

        Console.WriteLine("Método trim");
        string trim = original.Trim ();
        Console.WriteLine("-" + trim + "-");

        Console.WriteLine();





        Console.ReadLine ();
    }
}