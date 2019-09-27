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
            var item = new Item();
            var sut = new Checkout();

            sut.Scan(item);
        }
    }
}
