using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }


    }
}
