using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1.Entities
{
    public class Employee
    {
        public string Nome { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {
        }

        public Employee Employee(string nome, int hours, double valuePerHour)
        {
            Nome = nome;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}