namespace CafeBackend.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public byte Status { get; set; } // 1: Bekliyor, 2: Hazırlandı/Teslim, 3: İptal

        public Ticket? Ticket { get; set; }
        public Product? Product { get; set; }
    }
}