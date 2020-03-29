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
        public void InitialToCheckWithNoItemScanned_Test()
        {
            var totalValue = _checkoutService.GetTotal();
            Assert.AreEqual(totalValue , 0);
        }


        [Test]
        public void ItemWithoutSpecialPrice_Test()
        {
            //Arrange 
            var checkoutService = new CheckoutService();

            //Act
            checkoutService.ScanItem("A99");
            checkoutService.ScanItem("B15");
            checkoutService.ScanItem("C40");
            //Assert
            Assert.AreEqual(1.40, checkoutService.GetTotal());

        }

    }
}