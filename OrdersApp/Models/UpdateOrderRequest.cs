namespace OrdersApp.Models
{
    public class UpdateOrderRequest
    {
        public string? OrderName { get; set; }
        public double Price { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
