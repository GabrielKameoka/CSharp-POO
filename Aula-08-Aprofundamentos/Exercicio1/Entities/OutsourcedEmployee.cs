using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1.Entities
{
    public class OutsourcedEmployee : Entities.Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, )
        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}