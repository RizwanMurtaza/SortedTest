using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortedCheckout.Services
{
    public class CheckoutService : ICheckoutService
    {
        private List<string> _scanedItems = new List<string>();
        public void ScanItem(string item)
        {
            _scanedItems.Add(item);
        }
        public double GetTotal()
        {
            if (!_scanedItems.Any())
                return 0;

            return 1;
        }


    }
}
