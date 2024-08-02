using System;
using System.Globalization;
namespace Alunos
{
    class Program
    {
        static void Main (string[] args)
        {
            // Instanciando um objeto da classe Aluno
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            aluno.NotaFinal = aluno.Nota1 + aluno.Nota2 + aluno.Nota3;

            Console.WriteLine($"A nota do aluno é: {aluno.NotaFinal:F2}");

            if (aluno.NotaFinal <= 60)
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"Faltaram {60 - aluno.NotaFinal:F2} ");
            } 
            else
            {
                Console.WriteLine("Aprovado!!");
            }

            Console.WriteLine();
            Console.WriteLine("Entre qualquer coisa para sair");
            Console.ReadLine();
        }
    }
}
