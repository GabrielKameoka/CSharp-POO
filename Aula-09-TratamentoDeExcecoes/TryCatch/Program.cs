using System;
namespace EstruturaTryCatch;
public class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        try
        {
            System.Console.WriteLine("Tratando divisão por 0");
            System.Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            System.Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());

            int resultado = a / b;
            System.Console.WriteLine($"resultado {resultado}");
        }
        catch (DivideByZeroException e)
        {
            System.Console.WriteLine();
            Console.WriteLine("Ocorreu um erro: " + e.Message);
        }
        catch (FormatException e)
        {
            System.Console.WriteLine("Erro de formato: " + e.Message);
        }
        finally
        {
            System.Console.WriteLine("Mano davis é gostosão");
        }
    }
}