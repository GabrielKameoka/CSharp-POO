using System;
namespace Projeto3_5;
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
        System.Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
    }
}
public class Aluno : Pessoa
{
    public double Nota { get; set; }
    public Aluno(string nome, int idade, double nota) : base (nome, idade) //construtor que herda da superclasse Pessoa e tem um novo valor Nota 
    {
        Nota = nota;
    }
    public override void Apresentar()
    {
        System.Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou aluno de nota {Nota}");
    }
}