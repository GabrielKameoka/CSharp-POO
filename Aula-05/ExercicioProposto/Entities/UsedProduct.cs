using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;

namespace ExercicioProposto.Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManuFactureDate { get; set; }
        public UsedProduct()
        {}
        public UsedProduct(string name, decimal price, DateTime manuFactureDate) : base(name, price)
        {
            ManuFactureDate = manuFactureDate;
        }

        public override string PriceTag()
        {
            return Name + " (used) "
            + " $ "
            + Price.ToString("F2", CultureInfo.InvariantCulture) 
            + " (Manufacture date: " + ManuFactureDate.ToString("dd/MM/yyyy")
            + ")";
        }
    }
}