﻿using System;

namespace Aula01 {
    class Program {
        static void Main (string[] args ){

            string frase = Console.ReadLine();

            // string x = Console.ReadLine();
            // string y = Console.ReadLine();
            // string z = Console.ReadLine();

            string s = Console.ReadLine();
            string[] vetor = s.Split(' ');
            string a = vetor[0];
            string b = vetor[1];
            string c = vetor[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            // Console.WriteLine(x);
            // Console.WriteLine(y);
            // Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


        }
    }
}