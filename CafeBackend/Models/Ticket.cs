namespace CafeBackend.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int TableId { get; set; }
        public byte Status { get; set; } // 1: Açık, 2: Hesap İstendi, 3: Ödendi
        public decimal TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }

        public Table? Table { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}