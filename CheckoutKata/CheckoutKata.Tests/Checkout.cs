using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckoutKata.Tests
{
    internal class Checkout : ICheckout
    {
        private readonly List<string> _skus;
        private readonly Data _data;
        public Checkout()
        {
            _data = new Data();
            _skus = new List<string>();
        }

        public int GetTotal()
        {
            int total = 0;
            foreach (var sku in _skus)
            {
                var item = _data.items.FirstOrDefault(i => i.SKU == sku);
                total += item.UnitPrice;
            }
            return total;
        }

        public void Scan(string sku)
        {
            _skus.Add(sku);
        }
    }
}