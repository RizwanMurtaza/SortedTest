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
           

            //Act
            var A99Product = new CheckoutItem("A99", 0.50);
            var B15Product = new CheckoutItem("B15", 0.30);
            var C40Product = new CheckoutItem("C40", 0.60);


            _checkoutService.ScanItem(A99Product);
            _checkoutService.ScanItem(B15Product);
            _checkoutService.ScanItem(C40Product);
            //Assert
            Assert.AreEqual(1.40, _checkoutService.GetTotal());

        }


        [Test]
        public void itemWithSpecialPrice_Test()
        {
            //Arrange 
           

            //Act
            var A99Product = new CheckoutItem("A99", 0.50);
            var B15Product = new CheckoutItem("B15", 0.30);

            _checkoutService.ScanItem(A99Product);
            _checkoutService.ScanItem(A99Product);
            _checkoutService.ScanItem(A99Product);

            _checkoutService.ScanItem(B15Product);
            _checkoutService.ScanItem(B15Product);


            //Assert
            Assert.AreEqual(1.75, _checkoutService.GetTotal());

        }

    }
}