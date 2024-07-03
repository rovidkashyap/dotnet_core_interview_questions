namespace DDD_Pattern.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; private set; }
        public string ProductName { get; private set; }
        public int Quantity { get; private set; }
        public DateTime OrderDate { get; private set; }

        public Order(string productName, int quantity)
        {
            Id = Guid.NewGuid();
            ProductName = productName;
            Quantity = quantity;
            OrderDate = DateTime.Now;
        }

        public void UpdateQuantity(int newQuantity)
        {
            if (newQuantity <= 0)
                throw new ArgumentException("Quantity must be greater than zero.");

            Quantity = newQuantity;
        }
    }
}
