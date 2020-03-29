using NUnit.Framework;
using SortedCheckout.Domain;
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
            var A99Product = new CheckoutItem("A99", 0.50);
            var B15Product = new CheckoutItem("B15", 0.30);
            var C40Product = new CheckoutItem("C40", 0.60);


            checkoutService.ScanItem(A99Product);
            checkoutService.ScanItem(B15Product);
            checkoutService.ScanItem(C40Product);
            //Assert
            Assert.AreEqual(1.40, checkoutService.GetTotal());

        }


        [Test]
        public void itemWithSpecialPrice_Test()
        {
            //Arrange 
            var checkoutService = new CheckoutService();

            //Act
            var A99Product = new CheckoutItem("A99", 0.50);
            var B15Product = new CheckoutItem("B15", 0.30);

            checkoutService.ScanItem(A99Product);
            checkoutService.ScanItem(A99Product);
            checkoutService.ScanItem(A99Product);

            checkoutService.ScanItem(B15Product);
            checkoutService.ScanItem(B15Product);


            //Assert
            Assert.AreEqual(1.75, checkoutService.GetTotal());

        }

    }
}