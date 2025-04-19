namespace ClothingStore.Models
{
    public class Order
    {
        public string  OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public decimal TotalAmount { get; set; }
    }
}