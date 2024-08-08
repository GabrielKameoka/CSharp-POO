namespace Exercicio5_4;
public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }

    public Livro(string titulo, string autor, int ano)
    {
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
    }

    public string MostrarDetalhes()
    {
        return $"O livro {Titulo} do(a) {Autor} foi lançado em {Ano}.";
    }

    public string EhAntigo()
    {
        if (DateTime.Now.Year - Ano > 10)
        {
            return "O livro foi lançado a mais de 10 anos.";
        }
        else
        {
            return "O livro é recente.";
        }
    }
}