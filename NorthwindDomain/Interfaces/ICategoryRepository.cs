using System.ComponentModel;
using NorthwindDomain.AutoGen;

namespace NorthwindDomain.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
        Category GetCategory(long id);
        Category CreateCategory(Category category);
        void DeleteCategory(long id);
        
    }
}