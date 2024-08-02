using System;

namespace Exercicio3_3
{
    public class Livro
    {
        public string Titulo;
        public string Autor;
        public int Ano;

        public Livro ()
        {
            Titulo = "Título não informado";
            Autor = "Autor não informado";
            Ano = 0;
        }

        public Livro (string titulo, string autor, int ano)
        {
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
        }

        public Livro (string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
            Ano = 2020;
        }

        public void MostrarDetalhes ()
        {
            Console.WriteLine ($"Título: {Titulo}");
            Console.WriteLine ($"Autor: {Autor}");
            Console.WriteLine ($"Ano de Publicação: {Ano}");
        }
    }
}