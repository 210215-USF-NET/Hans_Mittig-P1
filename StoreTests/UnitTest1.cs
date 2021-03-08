using System;
using StoreModels;
using Xunit;

namespace StoreTests
{
    public class UnitTest1
    {   private Inventory inv = new Inventory();
        private Product p = new Product();
        [Theory]
        [InlineData (0, true)]
        [InlineData(-2, false)]
        public void CheckQuantity(int q, bool expected)
        {
            bool result = inv.CheckQuantity(q);
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData (259.00, true)]
        [InlineData(-2.00, false)]
        public void checkPrice(decimal q, bool expected)
        {
            bool result = p.checkPrice(q);
            Assert.Equal(result, expected);
        }
    }
}
