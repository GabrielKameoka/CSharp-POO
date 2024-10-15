using System;
namespace Generics_parte1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 4;
            double num2 = 4;

            string str1 = "10";
            string str2 = "10";

            ComparaClass<double, double> c = new ComparaClass<double, double>();
            c.compara(num1, num2);
        }
    }
}