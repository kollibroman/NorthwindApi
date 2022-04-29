using NorthwindApp.Interfaces;
using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;

namespace NorthwindApp.Services
{
    public class ProductService : IProductService
    {
        public ProductDto AddProductDto(CreateNewProductDto dto)
        {
            throw new NotImplementedException();
        }

        public void DeleteProductDto(long id)
        {
            throw new NotImplementedException();
        }

        public ProductDto GetProductDto(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductDto> GetProductDtos()
        {
            throw new NotImplementedException();
        }
    }
}