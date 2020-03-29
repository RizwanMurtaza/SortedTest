using System;

namespace SortedCheckout.Domain
{
    public class CheckoutItem
    {
        public string SKU { get; set; }
        public double Price { get; set; }
        public CheckoutItem(string sku, double price)
        {
            SKU = sku;
            Price = price;
        }
    }
}
