﻿using System;
using System.Globalization;

namespace Exercicio02 {

    class Program {

        static void Main (string[] args) {

            Console.WriteLine("Digite seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse (Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Seu nome é {nome}, sua casa tem {quartos} quartos, o preço do produto é {preco}");

            Console.WriteLine("Entre seu último nome, idade e altura");

            string[] vet = Console.ReadLine().Split(' ');
            string ultimoNome = vet[0];
            int idade = int.Parse (vet[1]);
            double altura = double.Parse (vet[2], CultureInfo.InvariantCulture);
            
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

        }
    }
}