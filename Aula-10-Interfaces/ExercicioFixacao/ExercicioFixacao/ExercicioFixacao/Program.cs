using System;
using ExercicioFixacao.Entities;
using ExercicioFixacao.Services;
using ExercicioFixacao.Services.Interfaces;

namespace ExercicioFixacao;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter contract data: ");
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Date: ");
        DateTime date = Convert.ToDateTime(Console.ReadLine());
        Console.Write("Contact value: ");
        double totalValue = double.Parse(Console.ReadLine());
        Console.Write("Enter number of installments: ");
        int amount  = int.Parse(Console.ReadLine());
        
        Contract contract = new Contract(number, date, totalValue);

        IOnlinePaymentService onlinePaymentService = new PaypalService();
        
        ContractServices contractServices = new ContractServices(onlinePaymentService);
        
        contractServices.ProcessContract(contract, amount);

        Console.WriteLine("Due Date: ");
        foreach (Installment installment in contract.Installments)
        {
            Console.WriteLine($"{installment.DueDate.ToString("dd/MM/yyyy")}, Amount: {installment.Amount:C2}");
        }
    }
}

