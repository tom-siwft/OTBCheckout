﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckoutKata.Tests
{
    [TestClass]
    public class ValuesReturned
    {
        [TestMethod]
        public void A_Returns_Correct_Single_Value()
        {
            var checkout = new Checkout();
            checkout.Scan("A");
            int value = checkout.GetTotal();
            Assert.AreEqual(value, 50);
        }
        [TestMethod]
        public void B_Returns_Correct_Single_Value()
        {
            var checkout = new Checkout();
            checkout.Scan("B");
            int value = checkout.GetTotal();
            Assert.AreEqual(value, 30);
        }
        [TestMethod]
        public void C_Returns_Correct_Single_Value()
        {
            var checkout = new Checkout();
            checkout.Scan("C");
            int value = checkout.GetTotal();
            Assert.AreEqual(value, 20);
        }
        [TestMethod]
        public void D_Returns_Correct_Single_Value()
        {
            var checkout = new Checkout();
            checkout.Scan("D");
            int value = checkout.GetTotal();
            Assert.AreEqual(value, 15);
        }
    }
}
