namespace DDD_Pattern.Domain.ValueObjects
{
    public class OrderDetails
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }

        public OrderDetails(string productName, int quantity)
        {
            if (string.IsNullOrEmpty(productName)) throw new ArgumentException("Product Name is required.");
            if (quantity <= 0) throw new ArgumentException("Quantity must be greater than zero.");

            ProductName = productName;
            Quantity = quantity;
        }
    }
}
