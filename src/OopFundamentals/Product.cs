namespace OopFundamentals
{
    public class Product
    {
        public string Name { get; private set;}
        public string Description { get; private set; }
        public double Price { get; private set; }
        public static int ProductId { get; private set; }

        public Product(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
            ProductId++;
        }
    }
}