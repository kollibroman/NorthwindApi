using System.ComponentModel;
using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;
using NorthwindDomain.AutoGen;

namespace NorthwindApp.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDto> GetCategoryDtos();
        CategoryDto GetCategoryDto(long id);
        CategoryDto AddCategory(CreateCategoryDto dto);
        void DeleteCategory(long id);
    }
}