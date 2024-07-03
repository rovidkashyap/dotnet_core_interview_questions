﻿namespace Core.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
