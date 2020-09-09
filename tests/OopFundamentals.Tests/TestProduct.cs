using Xunit;

namespace OopFundamentals.Tests
{
    public class TestProduct
    {
        [Fact]
        public void TestConstructor()
        {
        //Given
            var product = new Product("beer", "refreshing beverage for adults", 3.8);
        //When
        //Then
            Assert.Equal("beer", product.Name);
            Assert.Equal("refreshing beverage for adults", product.Description);
            Assert.Equal(3.8, product.Price);
        }
    }
}