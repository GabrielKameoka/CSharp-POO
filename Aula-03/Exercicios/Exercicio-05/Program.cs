/*
Crie uma classe Livro:

Atributos: Título (string), Autor (string), Ano de Publicação (int).
Construtor: Um construtor que recebe os valores para inicializar os atributos.
Métodos:
MostrarDetalhes(): Imprime na tela as informações do livro formatadas.
EhAntigo(): Retorna um booleano indicando se o livro foi publicado há mais de 10 anos.

Crie uma classe Biblioteca:
Atributo: Um array de objetos do tipo Livro para armazenar os livros da biblioteca.
Construtor: Um construtor que define o tamanho máximo da biblioteca.
Métodos:
AdicionarLivro(Livro livro): Adiciona um livro à biblioteca, se houver espaço disponível.
BuscarLivroPorTitulo(string titulo): Retorna o livro com o título informado, ou null se não encontrar.
ListarLivrosAntigos(): Imprime na tela os detalhes de todos os livros antigos da biblioteca.
        
Crie uma classe Program:
Instancie objetos da classe Livro e adicione-os à biblioteca.
Teste os métodos da classe Biblioteca.
*/

using System;
namespace Exercicio5_4;
class Program
{
    static void Main(string[] args)
    {
        Livro livro1 = new Livro("Rainha vermelha", "Victoria Aveyard", 2015);
        System.Console.WriteLine(livro1.MostrarDetalhes());
        System.Console.WriteLine(livro1.EhAntigo());
    }
}