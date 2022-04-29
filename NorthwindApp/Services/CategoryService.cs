using NorthwindApp.Interfaces;
using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;

namespace NorthwindApp.Services
{
    public class CategoryService : ICategoryService
    {
        public CategoryDto AddCategory(CreateCategoryDto dto)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(long id)
        {
            throw new NotImplementedException();
        }

        public CategoryDto GetCategoryDto(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryDto> GetCategoryDtos()
        {
            throw new NotImplementedException();
        }
    }
}