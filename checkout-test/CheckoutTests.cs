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
    }
}
