using System;
using System.Collections.Generic;
namespace Composicao.Entities;

public class Biblioteca
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public List<Livro> livros { get; set; }

    public Biblioteca()
    {
        livros = new List<Livro>();
    }

    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
    }

    public void RemoverLivro(Livro livro)
    {
        livros.Remove(livro);
    }

    public Livro BuscarLivroPorTitulo(string titulo)
    {
        return livros.FirstOrDefault(l => l.Titulo == titulo);
    }
}