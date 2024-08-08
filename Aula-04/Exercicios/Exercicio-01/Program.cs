using System;
namespace Exercicio1_4;

class Livro
{
    public string Nome { get; set; }
    public int Lancamento { get; set; }

    // Construtor que recebe os parâmetros Nome e Lancamento
    public Livro(string nome, int lancamento)
    {
        Nome = nome;
        Lancamento = lancamento;
    }
    public override string ToString()
    {
        return $"Título: {Nome}, Ano: {Lancamento}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando uma instância da classe Livro usando o construtor
        Livro livro1 = new Livro("Rainha Vermelha", 2010);
        Livro livro2 = new Livro("Fogo e gelo", 2014);
        Livro livro3 = livro2;

        Console.WriteLine($"O livro 1 está apontando para o {livro1}");
        Console.WriteLine($"O livro 2 está apontando para o {livro2}");
        Console.WriteLine($"O livro 3 está apontando para o {livro3}");
    }
}