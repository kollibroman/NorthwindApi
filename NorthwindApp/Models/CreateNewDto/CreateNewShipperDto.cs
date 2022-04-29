namespace NorthwindApp.Models.CreateNewDto
{
    public class CreateNewShipperDto
    {
        public long ShipperId { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? Phone { get; set; }
    }
}