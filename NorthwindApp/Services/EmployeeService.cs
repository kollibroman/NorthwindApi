using NorthwindApp.Interfaces;
using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;

namespace NorthwindApp.Services
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeDto AddEmployee(CreateNewEmployeeDto dto)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(long id)
        {
            throw new NotImplementedException();
        }

        public EmployeeDto GetEmployeeDto(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetEmployeeDtos()
        {
            throw new NotImplementedException();
        }
    }
}