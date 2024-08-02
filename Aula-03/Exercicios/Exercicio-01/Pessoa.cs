using System;

namespace Exercicio1_3
{
    class Pessoa
    {
        public string Nome;
        public int Idade;
        public double Altura;

        public Pessoa (string nome, int idade, double altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }
         public string Apresentar ()
        {
            return $"Olá, meu nome é {Nome}. Tenho {Idade} anos e minha altura é {Altura}m.";
        }
    }
}