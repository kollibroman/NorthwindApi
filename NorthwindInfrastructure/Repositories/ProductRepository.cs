using NorthwindDomain.AutoGen;
using NorthwindDomain.Interfaces;

namespace NorthwindInfrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Northwind _dbcontext;
        public ProductRepository(Northwind dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dbcontext.Products.ToList();
        }
        public Product GetProduct(long id)
        {
            return _dbcontext.Products.SingleOrDefault(p => p.ProductId == id);
        }

        public Product CreateProduct(Product product)
        {
            _dbcontext.Add(product);
            _dbcontext.SaveChanges();
            return product;
        }

        public void DeleteProduct(long id)
        {
            var product = _dbcontext.Products.SingleOrDefault(p => p.ProductId == id);
            _dbcontext.Remove(product);
            _dbcontext.SaveChanges();
        }

    }
}