﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace checkout_app
{
    public class Checkout
    {
        private readonly IEnumerable<Offer> _offers = new List<Offer>();
        private List<Item> _items = new List<Item>();
        private decimal _total = 0m;

        public Checkout(){}

        public Checkout(IEnumerable<Offer> offers)
        {
            _offers = offers;
        }
        
        public decimal Total() => _total;

        public void Scan(Item item)
        {
            _items.Add(item);
            _total += item.UnitPrice;
            ApplyFirstValidOffer(item);
        }

        private void ApplyFirstValidOffer(Item item)
        {
            var itemCount = _items.Count(i => i.Sku == item.Sku);
            var validOffer = _offers.FirstOrDefault(offer => offer.Sku == item.Sku && itemCount % offer.Quantity == 0);

            if (validOffer != null)
                _total = _total - (item.UnitPrice * validOffer.Quantity) + validOffer.Price;
        }
    }
}
