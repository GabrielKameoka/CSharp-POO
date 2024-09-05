using System;
namespace Exercicio5_4;
class Program
{
    static void Main (string[] args)
    {
        List<Funcionario> funcionarios = new List<Funcionario>();
        Console.Write("Quantos funcionários serão adicionados? ");
        int Quantidade = int.Parse(Console.ReadLine());

        for (int i = 0; i < Quantidade; i++)
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"# {i}");
            System.Console.Write("Id: ");
            int Id = int.Parse(Console.ReadLine());
            System.Console.Write("Nome: ");
            string Nome = Console.ReadLine();
            System.Console.Write("Salário: ");
            double Salario = double.Parse(Console.ReadLine());

            Funcionario fun = new Funcionario(Id, Nome, Salario);
            funcionarios.Add(fun);
        }

        System.Console.WriteLine("Digite o id do funcionário");
        int ProcuraId = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Salário atualizado");
        foreach(Funcionario obj in funcionarios)
        {
            System.Console.WriteLine(obj);
        }
    }
}