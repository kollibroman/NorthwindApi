using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;

namespace NorthwindApp.Interfaces
{
    public interface IEmployeeTerritoryService
    {
        IEnumerable<EmployeeTerritoryDto> GetEmployeeTerritoryDtos();
        CategoryDto GetEmployeeterritoryDto(long id);
        CategoryDto AddEmployeeTerritoryDto(CreateNewEmployeeTerritoryDto dto);
        void DeleteEmployeeTerritoryDto(long id);
    }
}