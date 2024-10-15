using System;
namespace EntendendoMemoria;
class Program
{
    static void Main(string[] args)
    {
        string meuNome = "Gabriella";//criando variáveis na memória stack
        int minhaIdade = 30;
        System.Console.WriteLine($"Meu nome é {meuNome} e tenho {minhaIdade}");

        System.Console.WriteLine();

        Pessoa p1 = new Pessoa("Gabriel", 20); //criando uma variável na memória stack apontando para um objeto na memória heap
        Pessoa p2 = new Pessoa("Geraldo", 56);
        Pessoa p3 = p1;// criando uma variável na memória stack que aponta para o MESMO objeto que o p1 aponta
        System.Console.WriteLine(p1);
        System.Console.WriteLine(p2);
        System.Console.WriteLine(p3);
    }
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public Pessoa()
        {

        }
        public override string ToString()
        {
            return $"Meu nome é {Nome} e tenho {Idade} anos";
        }
    }
}