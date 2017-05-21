using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata.Tests
{
    class Data
    {
        public List<Item> items = initialiseItems();

        public static List<Item> initialiseItems()
        {
            var values = new List<Item>();
            Item item1 = new Item { SKU = "A", UnitPrice = 50, SpecialPrice = 130, SpecialCondition = 3 };
            Item item2 = new Item { SKU = "B", UnitPrice = 30, SpecialPrice = 45, SpecialCondition = 2 };
            Item item3 = new Item { SKU = "C", UnitPrice = 20, SpecialPrice = null, SpecialCondition = null };
            Item item4 = new Item { SKU = "D", UnitPrice = 15, SpecialPrice = null, SpecialCondition = null };
            values.Add(item1);
            values.Add(item2);
            values.Add(item3);
            values.Add(item4);
            return values;
        }

    }

    public class Item
    {
        public string SKU { get; internal set; }
        public int UnitPrice { get; internal set; }
        public int? SpecialPrice { get; internal set; }
        public int? SpecialCondition { get; internal set; }
    }
}
