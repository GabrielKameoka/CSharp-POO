using System;
using System.Globalization;
using System.Security.AccessControl;
using ExercicioPedidos.Entities;
using ExercicioPedidos.Entities.Enums;
namespace ExercicioPedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter cliente data: ");
            System.Console.Write("Name: ");
            string name = Console.ReadLine();
            System.Console.Write("Email: ");
            string email = Console.ReadLine();
            System.Console.Write("Birthdate (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());

            System.Console.WriteLine();

            System.Console.WriteLine("Enter order data: ");
            System.Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            System.Console.Write("How many items to this order? ");
            int QuantityItem = int.Parse(Console.ReadLine());

            Client client = new Client(name, email, birth);
            Order order = new Order(DateTime.Now, status, client);

            for (int i = 1;i <= QuantityItem; i++)
            {
                System.Console.WriteLine();

                System.Console.WriteLine($"Enter #{i} item data: ");

                System.Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();

                System.Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine());

                System.Console.Write("Quantity: ");
                int quantityProduct = int.Parse(Console.ReadLine());

                Product product = new Product(nameProduct, priceProduct);
                OrderItem orderItem = new OrderItem(quantityProduct, priceProduct, product);

                order.addItem(orderItem);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Order Summary:");
            System.Console.WriteLine(order);


        }  
    }
}