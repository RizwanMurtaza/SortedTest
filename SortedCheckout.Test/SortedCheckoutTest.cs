using NUnit.Framework;
using SortedCheckout.Services;

namespace SortedCheckout.Test
{
    public class SortedCheckoutTest
    {


        private ICheckoutService _checkoutService;
        [SetUp]
        public void Setup()
        {
            _checkoutService = new CheckoutService();
        }

        [Test]
        public void InitialToCheckWithNoItemScanned()
        {
            var totalValue = _checkoutService.GetTotal();
            Assert.AreEqual(totalValue , 0);
        }
    }
}