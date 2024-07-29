using System;
using System.Globalization;

namespace Exercicio6_2
{
    class Program
    {
        static void Main (string[] args)
        {
            Pessoa p = new Pessoa();

            Console.Write("Digite o seu nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Sua idade: ");
            p.Idade = int.Parse( Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Sua altura: ");
            p.Altura = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Suas informações: " + p.ExibirInfo());

            if (p.Idade <= 18)
            {
                Console.WriteLine("Você é menor de idade!!");
            }
            else
            {
                Console.WriteLine("Você é menor de idade!!");
            }

            Console.WriteLine( "Entre qualquer tecla para sair");
            Console.ReadLine();
        }
    }
}