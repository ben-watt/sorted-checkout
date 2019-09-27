using System;
using Xunit;
using checkout_app;
using System.Collections.Generic;

namespace checkout_test
{
    public class CheckoutTests
    {
        [Fact]
        public void Can_Create_Checkout()
        {
            var sut = new Checkout();
        }

        [Fact]
        public void Able_To_Scan_Item() 
        {
            var item = new Item("A99", 1.99m);
            var sut = new Checkout();

            sut.Scan(item);
        }

        [Fact]
        public void Able_To_Request_Total_Starting_Amount_Is_Zero() 
        {
            var item = new Item("A99", 1.99m);
            var sut = new Checkout();

            var total = sut.Total();

            Assert.Equal(0m, total);
        }

        [Fact]
        public void When_One_Item_Is_Added_Total_Increases_With_Price() 
        {
            var item = new Item("A99", 1.99m);
            var sut = new Checkout();

            sut.Scan(item);
            var total = sut.Total();

            Assert.Equal(1.99m, total);
        }

        [Fact]
        public void When_Two_Items_Added_And_Offer_Applies_Reduce_Total_Correctly() 
        {
            var item = new Item("A99", 2m);
            var offers = new List<Offer>() {
                new Offer("A99", 2, 2.99m)
            };

            var sut = new Checkout(offers);

            sut.Scan(item);
            sut.Scan(item);
            var total = sut.Total();

            Assert.Equal(2.99m, total);
        }
    }
}
