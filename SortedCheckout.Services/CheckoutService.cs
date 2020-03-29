using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SortedCheckout.Domain;

namespace SortedCheckout.Services
{
    public class CheckoutService : ICheckoutService
    {
        private readonly List<CheckoutItem> _scannedItems = new List<CheckoutItem>();
        public void ScanItem(CheckoutItem item)
        {
            _scannedItems.Add(item);
        }
        public double GetTotal()
        {
            if (!_scannedItems.Any())
                return 0;

            var totalDiscount = 0.0;
            foreach (var item in GetSpecialPriceItems())
            {
                var currentItem = _scannedItems.Where(x => x.SKU.Equals(item.Key));
                var discountQuantity = currentItem.Count() / item.Value.Quantity;
                totalDiscount += discountQuantity * item.Value.Discount;
            }
            return _scannedItems.Sum(x => x.Price) - totalDiscount;
        }
        private Dictionary<string, DiscountQuantityPair> GetSpecialPriceItems()
        {
            return new Dictionary<string, DiscountQuantityPair>
            {{"A99", new DiscountQuantityPair(){Discount = 0.20, Quantity = 3}},
                { "B15", new DiscountQuantityPair() { Discount = 0.15, Quantity = 2 } } };
        }

    }
    struct DiscountQuantityPair
    {
        public int Quantity;
        public double Discount;
    }
}

