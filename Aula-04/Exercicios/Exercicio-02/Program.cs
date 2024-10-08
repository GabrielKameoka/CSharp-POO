﻿/*
A dona de um pensionato possui dez quartos para alugar para estudantes,
sendo esses quartos identificados pelos números 0 a 9.

Quando um estudante deseja alugar um quarto, deve-se registrar o nome
e email deste estudante.

Fazer um programa que inicie com todos os dez quartos vazios, e depois
leia uma quantidade N representando o número de estudantes que vão
alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
N estudantes. Para cada registro de aluguel, informar o nome e email do
estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
um relatório de todas ocupações do pensionato, por ordem de quarto.
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        Quartos[] vect = new Quartos[10];

        System.Console.Write("Quantos quartos serão alugados? ");
        int n = int.Parse(Console.Readline());

        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine("Aluguel #" + vect[i]);
            System.Console.Write(Estudante());
            string Nome = Console.ReadLine();
        }


        Console.ReadLine();
    }
}