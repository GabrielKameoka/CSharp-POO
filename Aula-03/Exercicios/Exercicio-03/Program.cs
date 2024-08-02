/*
Crie uma classe Livro para representar um livro em uma biblioteca. Essa classe deve ter os seguintes atributos:

Título: Uma string para o título do livro.
Autor: Uma string para o nome do autor.
Ano de publicação: Um inteiro para o ano de publicação.
ISBN: Uma string para o número ISBN do livro.
Implemente os seguintes construtores:

Construtor padrão: Inicializa todos os atributos com valores padrão (por exemplo, "Título não informado", "Autor não informado", 0, "ISBN não informado").
Construtor com todos os parâmetros: Permite criar um objeto Livro com todos os atributos personalizados.
Construtor que recebe apenas título e autor: Inicializa o ano de publicação com o ano atual e o ISBN com um valor padrão.

Adicione um método MostrarDetalhes que exibe as informações do livro em um formato legível.
*/

using System;
namespace Exercicio3_3
{
    class Program
    {
        static void Main (string[] args)
        {
            Livro livro1 = new Livro("Rainha Vermelha", "Dona Reginalda", 2014 );//criando um objeto (livro) com o nome de Rainha vermelha, lançada pela Dona Rejinalda no ano de 2014
            livro1.MostrarDetalhes ();

            Console.WriteLine();

            Livro livro2 = new Livro ("Casa do dragão", "Senhor Miyagi");
            livro2.MostrarDetalhes ();

            Console.ReadLine();
        }
    }
}