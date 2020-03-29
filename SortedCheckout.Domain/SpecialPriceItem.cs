using System;
using System.Collections.Generic;
using System.Text;

namespace SortedCheckout.Domain
{
    public class SpecialPriceItem
    {
        //public CheckoutItem Item { get; set; }
        public string SKU { get; set; }
        public int QuantityToBuyForQualify { get; set; }
        public double TotalDiscount { get; set; }
    }
}
