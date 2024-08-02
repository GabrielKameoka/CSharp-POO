# C# notebook

Notebook used in C# course, heavily in-depth in Object-Oriented Programming.  
Also show my knowledge in solving exercises from basic to advanced.  

Example:

```
using System;
using System.Globalization;

namespace Exercicio5_2
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido ()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario (double porcentagem)
        {
            SalarioBruto = SalarioBruto + ( SalarioBruto * porcentagem / 100.0 );
        }

        public override string ToString ()
        {
            return $"{Nome}, R$ {SalarioLiquido ().ToString ("F2")}";
        }
    }

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
            Console.WriteLine("Funcionário: " + fun);

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
```
This C# program simulates a basic employee management system. It can:

****Create an employee object:**** Instantiates a Funcionario object to store employee information.  
**Input data:** Prompts the user to enter the employee's name, gross salary, and tax amount.  
**Calculate net salary:** Calculates the employee's net salary by subtracting the tax from the gross salary.  
**Display information:** Displays the employee's name and formatted net salary (with two decimal places).  
**Increase salary:** Allows the user to increase the employee's gross salary by a specified percentage.  
**Update information:** Displays the employee's updated information after the salary increase.  
<hr>

This is just a small exercise proposed in class. If you want to learn with the same course, this is <a href="https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/?couponCode=MCLARENT71824">C# COMPLETO Programação Orientada a Objetos + Projetos</a>
