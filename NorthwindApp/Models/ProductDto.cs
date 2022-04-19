namespace NorthwindApp.Models
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; } 
        public string? QuantityPerUnit { get; set; }
        public byte[]? UnitPrice { get; set; }
        public int? UnitsInStock { get; set; } 
        public byte[] Discontinued { get; set; } = null!;
        public Category? Category { get; set; }
        public Supplier? Supplier { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}