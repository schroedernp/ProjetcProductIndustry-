using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductIndustry.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee)
            : base( name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.PriceTag());
            sb.Append(TotalPrice().ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(" (Custom fee: $ ");
            sb.Append(CustomsFee.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(")");
                
            return sb.ToString();
        }

        public double TotalPrice()
        {
           
            return Price + CustomsFee;
        }
    }
}
