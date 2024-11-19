using System;
using System.Globalization;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Round(4.3333));
            
        }
        public static float Round(double n)
        {
            string arredondando = n.ToString("F2");
            float numeroConvertido = float.Parse(arredondando);
            return numeroConvertido;
        }
    }
}