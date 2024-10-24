using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExercicioFixaxao.Entities.Exceptions;

namespace ExercicioFixaxao.Entities;
public class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter account data: ");
            System.Console.Write("Number: ");
            int Number = int.Parse(Console.ReadLine());
            System.Console.Write("Holder: ");
            string Holder = Console.ReadLine();
            System.Console.Write("Initial balance: ");
            double Balance = double.Parse(Console.ReadLine());
            System.Console.Write("Withdraw limit: ");
            double WithdrawLimit = double.Parse(Console.ReadLine());
            Account acc = new Account(Number, Holder, Balance, WithdrawLimit);

            System.Console.WriteLine();

            System.Console.Write("Enter amount for withdraw: ");
            double Amount = double.Parse(Console.ReadLine());
            acc.Withdraw(Amount);
            System.Console.WriteLine(acc);
        }
        catch (DomainException e)
        {
            System.Console.WriteLine("Erro na operação: " + e.Message);
        }
        catch (FormatException e)
        {
            System.Console.WriteLine("Valor inválido: " + e.Message);
        }
    }
}