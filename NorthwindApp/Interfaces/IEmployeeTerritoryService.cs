using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;

namespace NorthwindApp.Interfaces
{
    public interface IEmployeeTerritoryService
    {
        IEnumerable<EmployeeTerritoryDto> GetEmployeeTerritoryDtos();
        EmployeeTerritoryDto GetEmployeeterritoryDto(long id);
        EmployeeTerritoryDto AddEmployeeTerritoryDto(CreateNewEmployeeTerritoryDto dto);
        void DeleteEmployeeTerritoryDto(long id);
    }
}