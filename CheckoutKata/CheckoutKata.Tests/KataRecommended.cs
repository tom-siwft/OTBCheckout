using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckoutKata.Tests
{
    [TestClass]
    public class KataRecommended
    {
        [TestMethod]
        public void Nothing_Returns_Correct_Offer_Value()
        {
            var checkout = new Checkout();
            int value = checkout.GetTotal();
            Assert.AreEqual(value, 0);
        }
        [TestMethod]
        public void A_Returns_Correct_Offer_Value()
        {
            var checkout = new Checkout();
            checkout.Scan("A");
            int value = checkout.GetTotal();
            Assert.AreEqual(value, 50);
        }
        [TestMethod]
        public void AB_Returns_Correct_Offer_Value()
        {
            var checkout = new Checkout();
            checkout.Scan("A");
            checkout.Scan("B");
            int value = checkout.GetTotal();
            Assert.AreEqual(value, 80);
        }
        [TestMethod]
        public void CDBA_Returns_Correct_Offer_Value()
        {
            var checkout = new Checkout();
            checkout.Scan("C");
            checkout.Scan("D");
            checkout.Scan("B");
            checkout.Scan("A");
            int value = checkout.GetTotal();
            Assert.AreEqual(value, 115);
        }



        [TestMethod]
        public void AA_Returns_Correct_Offer_Value()
        {
            var checkout = new Checkout();
            checkout.Scan("A");
            checkout.Scan("A");
            int value = checkout.GetTotal();
            Assert.AreEqual(value, 100);
        }
        [TestMethod]
        public void AAA_Returns_Correct_Offer_Value()
        {
            var checkout = new Checkout();
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            int value = checkout.GetTotal();
            Assert.AreEqual(value, 130);
        }
        [TestMethod]
        public void AAAA_Returns_Correct_Offer_Value()
        {
            var checkout = new Checkout();
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            int value = checkout.GetTotal();
            Assert.AreEqual(value, 180);
        }
        [TestMethod]
        public void AAAAA_Returns_Correct_Offer_Value()
        {
            var checkout = new Checkout();
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            int value = checkout.GetTotal();
            Assert.AreEqual(value, 230);
        }
        [TestMethod]
        public void AAAAAA_Returns_Correct_Offer_Value()
        {
            var checkout = new Checkout();
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            int value = checkout.GetTotal();
            Assert.AreEqual(value, 260);
        }
    }
}
