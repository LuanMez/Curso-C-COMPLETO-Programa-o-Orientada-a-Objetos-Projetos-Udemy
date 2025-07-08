using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }

        public double totalPrice()
        {
            return Price + CustomFee;
        }
        
        public override string priceTag()
        {
            return Name
            + " $ "
            + Price.ToString("F2")
            + " (Customs fee: $ "
            + CustomFee
            + ")";
        }
    }
}