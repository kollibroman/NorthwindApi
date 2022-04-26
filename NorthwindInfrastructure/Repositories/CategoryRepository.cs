using NorthwindDomain.AutoGen;
using NorthwindDomain.Interfaces;

namespace NorthwindInfrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Northwind _dbContext;
        public CategoryRepository(Northwind dbcontext)
        {
            _dbContext = dbcontext;
        }
        public IEnumerable<Category> GetCategories()
        {
            return _dbContext.Categories.ToList();
        }

        public Category GetCategory(long id)
        {
           return _dbContext.Categories.SingleOrDefault(c => c.CategoryId == id);
        }
        public Category CreateCategory(Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return category;
        }

        public void DeleteCategory(long id)
        {
            var category = _dbContext.Categories.SingleOrDefault(c => c.CategoryId == id);
            _dbContext.Remove(category);
            _dbContext.SaveChanges();
        }

    }
}