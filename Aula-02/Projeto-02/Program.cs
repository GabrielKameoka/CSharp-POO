﻿using System;
using System.Globalization;
namespace Projeto2_2
{
    class Program
    {
        static void Main (string[] args)
        {

            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dadods do produto: " + p);

            Console.WriteLine("Digite algo para sair");
            Console.ReadLine();

        }
    }
}