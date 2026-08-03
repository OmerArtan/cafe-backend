namespace CafeBackend.Models
{
    public class Table
    {
        public int Id { get; set; }
        public string TableNo { get; set; } = string.Empty;
        public Guid QrToken { get; set; }
        public bool IsOccupied { get; set; }

        public ICollection<Ticket>? Tickets { get; set; }
    }
}