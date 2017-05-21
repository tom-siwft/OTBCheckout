using System;

namespace CheckoutKata.Tests
{
    internal class Checkout : ICheckout
    {
        public Checkout()
        {
            
        }

        public int GetTotal()
        {
            return 0;
        }

        public void Scan(string sku)
        {
        }
    }
}