using AutoMapper;
using NorthwindApp.Interfaces;
using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;
using NorthwindDomain.AutoGen;
using NorthwindDomain.Interfaces;

namespace NorthwindApp.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public IEnumerable<ProductDto> GetProductDtos()
        {
            var products = _repo.GetProducts();
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }
        public ProductDto GetProductDto(long id)
        {
            var product = _repo.GetProduct(id);
            return _mapper.Map<ProductDto>(product);
        }

        public ProductDto AddProductDto(CreateNewProductDto dto)
        {
            if(dto is null)
            {
                throw new Exception("Product can't be null");
            }
            var newproduct = _mapper.Map<Product>(dto);
            _repo.CreateProduct(newproduct);
            return _mapper.Map<ProductDto>(newproduct);
        }

        public void DeleteProductDto(long id)
        {
            _repo.DeleteProduct(id);
        }

    }
}