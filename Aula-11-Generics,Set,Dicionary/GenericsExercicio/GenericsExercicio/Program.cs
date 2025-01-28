using System;

namespace GenericsEx;

class Program
{
    static void Main(string[] args)
    {
        PrintServicesGeneric<string> printServices = new PrintServicesGeneric<string>();

        Console.WriteLine("How many values?");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string x = Console.ReadLine();
            printServices.AddValue(x);
        }
        
        printServices.Print();
        Console.WriteLine($"First: {printServices.First()}");
    }
}

