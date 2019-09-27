using System;
using Xunit;
using checkout_app;

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
    }
}
