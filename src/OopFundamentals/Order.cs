namespace OopFundamentals
{
    public class Order
    {
        public Product product {get; private set;}
        public int Quantity {get; private set;}
        public double PurchasedPrice {get; private set;}
        public static int OrderId {get; private set;}

        public Order(Product product, int quantity)
        {
            this.product = product;
            PurchasedPrice = product.Price;
            Quantity = quantity;
            OrderId++;
        }
    }
}