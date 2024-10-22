using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioProposto
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product()
        {}
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name
            + " $ "
            + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}