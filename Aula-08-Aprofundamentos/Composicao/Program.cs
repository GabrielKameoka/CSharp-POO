using System;
using Composicao.Entities;
namespace Composicao;
class Program
{
    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();

        Livro livro1 = new Livro("A guerra dos tronos", "Geroge R.R. Martin", 588);
        System.Console.WriteLine(livro1);

        biblioteca.AdicionarLivro(livro1);

        Livro livroEncontrado = biblioteca.BuscarLivroPorTitulo("A guerra dos tronos");
        if(livroEncontrado != null)
        {
            System.Console.WriteLine($"Livro encontrado: {livroEncontrado.ToString()}");
        }
    }
}