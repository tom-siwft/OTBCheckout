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
            //order and group skus
            var groupedSKUList = _skus.GroupBy(s => s);

            foreach (var group in groupedSKUList)
            {
                var sku = group.Key.ToString().ToUpper();
                //get sku quantity
                var quantity = group.Count();
                //if offer is triggered calculate remainder
                int SpecialCondition = Convert.ToInt32(_data.items.Where(c => c.SKU == sku).Select(c => c.SpecialCondition ?? 0).First());
                if (SpecialCondition > 0)
                {
                    int timesToRunOffer = quantity / SpecialCondition;
                    int remainder;
                    int q = Math.DivRem(quantity, SpecialCondition, out remainder);

                    if (timesToRunOffer > 0)
                    {
                        var offerPrice = _data.items.Where(x => x.SKU == sku).Select(x => x.SpecialPrice ?? 0).First();
                        for (int i = 0; i < timesToRunOffer; i++)
                        {
                            total += offerPrice;
                        }
                    }

                    if (remainder > 0)
                    {
                        var item = _data.items.FirstOrDefault(i => i.SKU == group.Key.ToString());
                        for (int i = 0; i < remainder; i++)
                        {
                            total += item.UnitPrice;
                        }
                    }
                }
                else
                {
                    var item = _data.items.FirstOrDefault(i => i.SKU == group.Key.ToString());
                    for (int i = 0; i < quantity; i++)
                    {
                        total += item.UnitPrice;
                    }
                }
            }
            return total;
        }

        public void Scan(string sku)
        {
            _skus.Add(sku);
        }
    }
}