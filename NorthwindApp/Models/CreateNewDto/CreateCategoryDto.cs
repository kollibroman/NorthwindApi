namespace NorthwindApp.Models.CreateNewDto
{
    public class CreateCategoryDto
    {
         public long CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
    }
}