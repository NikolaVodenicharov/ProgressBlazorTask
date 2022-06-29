namespace ProgressBlazorTask.Data.Models
{
    public class Product
    {
        public int? ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitInStock { get; set; }

        public DateTime DeliveryOn { get; set; }
    }
}
