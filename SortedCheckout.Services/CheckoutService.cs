using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortedCheckout.Services
{
    public class CheckoutService : ICheckoutService
    {
        private readonly List<string> _scannedItems = new List<string>();
        public void ScanItem(string item)
        {
            _scannedItems.Add(item);
        }
        public double GetTotal()
        {
            if (!_scannedItems.Any())
                return 0;

            var totalPrice = 0.0;
            foreach (var item in _scannedItems)
            {
                switch (item)
                {
                    case "A99":
                        totalPrice += 0.50;
                        break;
                    case "B15":
                        totalPrice += 0.30;
                        break;
                    case "C40":
                        totalPrice += 0.60;
                        break;
                    default:
                        break;
                }
            }
            return totalPrice;
        }


    }
}
