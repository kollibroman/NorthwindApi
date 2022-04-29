using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;
using NorthwindDomain.AutoGen;

namespace NorthwindApp.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeDto> GetEmployeeDtos();
        EmployeeDto GetEmployeeDto(long id);
        EmployeeDto AddEmployee(CreateNewEmployeeDto dto);
        void DeleteEmployee(long id);
    }
}