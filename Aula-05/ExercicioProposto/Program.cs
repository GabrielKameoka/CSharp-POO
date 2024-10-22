using System;
using ExercicioProposto.Entities;
using System.Globalization;
namespace ExercicioProposto;
class Program
{
    static void Main(string[] args)
    {
        List<Product> list = new List<Product>();
        System.Console.Write("Enter the number of products: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            System.Console.WriteLine($"Product {i} data:");
            System.Console.Write("Common, used or imported(c/u/i)? ");
            char TipProduct = char.Parse(Console.ReadLine());
            if (TipProduct == 'c')
            {
                System.Console.Write("Name: ");
                string name = Console.ReadLine();

                System.Console.Write("Price: ");
                decimal price = decimal.Parse(Console.ReadLine());
                list.Add(new Product(name, price));
            }
            else if (TipProduct == 'u')
            {
                System.Console.Write("Name: ");
                string name = Console.ReadLine();

                System.Console.Write("Price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                System.Console.WriteLine("Manufacturedate (DD/MM/YYYY): ");
                string dataString = Console.ReadLine();
                DateTime date = DateTime.ParseExact(dataString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                list.Add(new UsedProduct(name, price, date));
            }
            else
            {
                System.Console.Write("Name: ");
                string name = Console.ReadLine();

                System.Console.Write("Price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                System.Console.Write("Customsfee: ");
                decimal customFee = decimal.Parse(Console.ReadLine());

                list.Add(new ImportedProduct(name, price, customFee));
            }
            
            System.Console.WriteLine();
            System.Console.WriteLine("Price tags: ");

            foreach (Product prod in list)
            {
                System.Console.WriteLine(prod.PriceTag());
            }
        }

    }
}