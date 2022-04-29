namespace NorthwindApp.Models.CreateNewDto
{
    public class CreateNewProductDto
    {
         public long ProductId { get; set; }
        public string ProductName { get; set; }
        public long? SupplierId { get; set; }
        public long? CategoryId { get; set; } 
        public string? QuantityPerUnit { get; set; }
        public byte[]? UnitPrice { get; set; }
        public long? UnitsInStock { get; set; } 
        public byte[] Discontinued { get; set; } = null!;
    }
}