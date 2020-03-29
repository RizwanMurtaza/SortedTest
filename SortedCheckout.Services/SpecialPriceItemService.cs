using System;
using System.Collections.Generic;
using System.Text;
using SortedCheckout.Domain;

namespace SortedCheckout.Services
{
    public class SpecialPriceItemService : ISpecialPriceItemService
    {
        public List<SpecialPriceItem> GetAvailableSpecialPriceItems()
        {
            var firstProduct = new SpecialPriceItem()
            {
                QuantityToBuyForQualify = 3,
                SKU = "A99",
                //Product =  new Product("A99",0.50),
                TotalDiscount = 0.20
            };
            var secondProduct = new SpecialPriceItem()
            {
                QuantityToBuyForQualify = 2,
                SKU = "B15",
                //Product = new Product("B15", 0.30),
                TotalDiscount = 0.15
            };
            return new List<SpecialPriceItem>() { firstProduct, secondProduct };
        }
    }
}
