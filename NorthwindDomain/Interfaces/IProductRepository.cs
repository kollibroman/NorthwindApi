using NorthwindDomain.AutoGen;

namespace NorthwindDomain.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(long id);
        Product CreateProduct(Product product);
        void DeleteProduct(long id);
    }
}