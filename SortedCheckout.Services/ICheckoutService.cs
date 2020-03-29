namespace SortedCheckout.Services
{
    public interface ICheckoutService
    {
        public void ScanItem(string item);
        public double GetTotal();
    }
}