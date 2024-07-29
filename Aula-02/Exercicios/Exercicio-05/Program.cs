using System;

namespace Exercicio5_2
{
    class Program
    {
        static void Main (string[] args)
        {
            Funcionario fun = new Funcionario();

            Console.Write("Nome: ");
            fun.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            fun.SalarioBruto = double.Parse( Console.ReadLine() );
            Console.Write("Imposto: ");
            fun.Imposto = double.Parse( Console.ReadLine() );

            Console.WriteLine();
            Console.WriteLine("Funcionário : " + fun);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine());
            fun.AumentarSalario(porcent);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + fun);


            Console.WriteLine();
            Console.WriteLine("Entre qualquer tecla para sair: ");
            Console.ReadLine();
        }
    }
}