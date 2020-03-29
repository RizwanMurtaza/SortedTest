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

            return _scannedItems.Sum(x => x.Price) - CalculateDiscount();
        }
        private double CalculateDiscount()
        {
            var specialPriceService = new SpecialPriceItemService();
            var specialItems = specialPriceService.GetAvailableSpecialPriceItems();
            var totalDiscount = 0.0;
            foreach (var item in specialItems)
            {
                var currentItems = _scannedItems.Where(x => x.SKU.Equals(item.SKU));
                var discountQuantity = currentItems.Count() / item.QuantityToBuyForQualify;
                totalDiscount += discountQuantity * item.TotalDiscount;
            }
            return totalDiscount;
        }

    }
 
}

