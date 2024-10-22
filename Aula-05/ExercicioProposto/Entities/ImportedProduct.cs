using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;

namespace ExercicioProposto.Entities
{
    public class ImportedProduct : Product
    {
        public decimal CustomFee { get; set; }
        public ImportedProduct()
        {}
        public ImportedProduct(string name, decimal price, decimal customFee) : base(name, price)
        {
            CustomFee = customFee; 
        }

        public double TotalPrice()
        {
            return (double) (Price + CustomFee);
        }

        public override string PriceTag()
        {
            return Name
            + " $ "
            + Price.ToString("F2", CultureInfo.InvariantCulture) 
            + "(Custom fee: $ "
            + CustomFee.ToString("F2", CultureInfo.InvariantCulture)
            + ")";
        }
    }
}