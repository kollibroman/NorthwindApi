using AutoMapper;
using NorthwindApp.Interfaces;
using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;
using NorthwindDomain.AutoGen;
using NorthwindDomain.Interfaces;

namespace NorthwindApp.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repo;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public IEnumerable<CategoryDto> GetCategoryDtos()
        {
            var categories = _repo.GetCategories();
            return _mapper.Map<IEnumerable<CategoryDto>>(categories);
        }
        public CategoryDto GetCategoryDto(long id)
        {
            var category = _repo.GetCategory(id);
            return _mapper.Map<CategoryDto>(category);
        }

        public CategoryDto AddCategory(CreateCategoryDto dto)
        {
            if(dto is null)
            {
                throw new Exception("Category can't be null");
            }
            var NewCategory = _mapper.Map<Category>(dto);
            _repo.CreateCategory(NewCategory);
            return _mapper.Map<CategoryDto>(NewCategory);
        }

        public void DeleteCategory(long id)
        {
            _repo.DeleteCategory(id);
        }

    }
}