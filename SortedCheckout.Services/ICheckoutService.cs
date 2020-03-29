using SortedCheckout.Domain;

namespace SortedCheckout.Services
{
    public interface ICheckoutService
    {
        public void ScanItem(CheckoutItem item);
        public double GetTotal();
    }
}