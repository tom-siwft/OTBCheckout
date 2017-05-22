using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata.Tests
{
    [TestClass]
    public class OffersCalculated
    {
        [TestMethod]
        public void A_Returns_Correct_Offer_Value()
        {
            var checkout = new Checkout();
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            int value = checkout.GetTotal();
            Assert.AreEqual(value, 130);
        }
    }
}
