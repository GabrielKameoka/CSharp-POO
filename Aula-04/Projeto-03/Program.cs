using System;
using System.Globalization;

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("São quantos produtos?");
        int n = int.Parse(Console.ReadLine());

        Product[] vect = new Product[n];

        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());
            vect[i] = new Product { Name = name, Price = price }; // Corrected index
        }

        double soma = 0;
        for (int i = 0; i < n; i++)
        {
            soma += vect[i].Price;
        }

        double avg = soma / n;
        System.Console.WriteLine("AVERAGE PRICE: " + avg.ToString("F2", CultureInfo.InvariantCulture));
    }
}