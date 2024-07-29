/*Crie uma classe chamada Pessoa que possua os atributos nome, idade e altura. Implemente um método chamado Apresentar que exiba na tela as informações da pessoa.*/
using System; 
namespace Exercicio6_2
{
    class Pessoa
    {
        public string Nome;
        public int Idade;
        public double Altura;

        public string ExibirInfo ()
        {
            return $"nome: {Nome}, idade: {Idade}, altura: {Altura:F2}";
        }
    }
}