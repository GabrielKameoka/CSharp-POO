using System;
namespace Projeto2_5;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Qual o nome do seu cão?");
        string nome = Console.ReadLine();
        System.Console.WriteLine("Qual é a idade do seu cão");
        int idade = int.Parse(Console.ReadLine());
        System.Console.WriteLine("O seu cão é adestrado?");
        bool adestrado = bool.Parse(Console.ReadLine());
        Cachorro cac1 = new Cachorro(nome, idade, adestrado);
        cac1.Apresentar();
    }
}