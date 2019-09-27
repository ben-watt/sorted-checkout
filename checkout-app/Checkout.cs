using System;
using System.Collections.Generic;
using System.Linq;

namespace checkout_app
{
    public class Checkout
    {
        private List<Item> _items = new List<Item>();
        public void Scan(Item item) 
        {
            _items.Add(item);
        }

        public decimal Total() => _items.Sum(x => x.Price);
    }
}
