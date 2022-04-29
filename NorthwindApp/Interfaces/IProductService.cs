using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;
using NorthwindDomain.AutoGen;

namespace NorthwindApp.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductDto> GetProductDtos();
        ProductDto GetProductDto(long id);
        ProductDto AddProductDto(CreateNewProductDto dto);
        void DeleteProductDto(long id);
    }
}