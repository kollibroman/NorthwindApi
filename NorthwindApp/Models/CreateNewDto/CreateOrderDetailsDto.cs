namespace NorthwindApp.Models.CreateNewDto
{
    public class CreateOrderDetailsDto
    {
        public long OrderId { get; set; }
        public long ProductId { get; set; }
        public byte[] UnitPrice { get; set; } = null!;
        public long Quantity { get; set; }
    }
}