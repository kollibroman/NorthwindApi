using NorthwindDomain.AutoGen;

namespace NorthwindDomain.Interfaces
{
    public interface IEmployeeTerritoryRepository
    {
        IEnumerable<EmployeeTerritory> GetEmployeeTerritories();
        EmployeeTerritory GetEmployeeTerritory(long id);
        EmployeeTerritory CreateEmployeeTerritory(EmployeeTerritory employeeTerritory);
        void DeleteEmployeeTerritory(long id);
    }
}