using System;
using Xunit;

namespace OopFundamentals.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCustomer()
        {
            var customer = new Customer("Bilbo", "Baggins");
            var expect = "Bilbo Baggins";
            Assert.Equal(expect, customer.FullName);
        }

        [Fact]
        public void TestLastName()
        {
            var customer = new Customer("John", "");
            var expect = "Doe";
            Assert.Equal(expect, customer.LastName);
        }
    }
}
