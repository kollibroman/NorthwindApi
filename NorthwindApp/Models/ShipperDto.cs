namespace NorthwindApp.Models
{
    public class ShipperDto
    {
        public long ShipperId { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? Phone { get; set; }
    }
}