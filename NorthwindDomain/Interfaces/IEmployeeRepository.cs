using NorthwindDomain.AutoGen;

namespace NorthwindDomain.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployee(long id);
        Employee CreateEmployee(Employee employee);
        void DeleteEmployee(long id);
    }
}