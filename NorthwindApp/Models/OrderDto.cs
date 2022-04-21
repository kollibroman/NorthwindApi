namespace NorthwindApp.Models
{
    public class OrderDto
    {
        public long OrderId { get; set; }
        public string? CustomerId { get; set; }
        public long? EmployeeId { get; set; }
        public byte[]? OrderDate { get; set; }
        public byte[]? ShippedDate { get; set; }
        public long? ShipVia { get; set; }
        public string? ShipName { get; set; }
        public string? ShipAddress { get; set; }
        public string? ShipCity { get; set; }
        public string? ShipRegion { get; set; }
        public string? ShipPostalCode { get; set; }
        public string? ShipCountry { get; set; }
    }
}