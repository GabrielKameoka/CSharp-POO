using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_05_ClasseSelada;

namespace Projeto_05_ClasseSelada;
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    public virtual void Apresentar()
    {
        System.Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}
public sealed class Professor : Pessoa //sealed(selado) está declarando que a classe Professor não pode ser herdada
{
    public double Salario { get; set; }

    public Professor(string nome, int idade, double salario) : base(nome, idade)
    {
        Salario = salario;
    }

    public sealed override void Apresentar()//seaked está declarando que o método Apresentar não pode ser herdada/sobreescrita
    {
        System.Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e meu salário é de {Salario}");
    }
}

//public class Aluno : Professor //Não pode herdar de Professor
public class Aluno : Pessoa
{
    public double Nota { get; set; }
    public Aluno (string nome, int idade, double nota) : base (nome, idade)
    {
        Nota = nota;
    }
    public sealed override void Apresentar()
    {
        System.Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} e sou aluno(a) de nota {Nota}.");
    }
}