using NorthwindDomain.AutoGen;
using NorthwindDomain.Interfaces;

namespace NorthwindInfrastructure.Repositories
{
    public class EmployeeTerritoryRepository : IEmployeeTerritoryRepository
    {
        private readonly Northwind _dbcontext;
        public EmployeeTerritoryRepository(Northwind dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IEnumerable<EmployeeTerritory> GetEmployeeTerritories()
        {
            return _dbcontext.EmployeeTerritories.ToList();
        }
        public EmployeeTerritory GetEmployeeTerritory(long id)
        {
            return _dbcontext.EmployeeTerritories.SingleOrDefault(et => et.EmployeeId == id);
        }
        public EmployeeTerritory CreateEmployeeTerritory(EmployeeTerritory employeeTerritory)
        {
            _dbcontext.Add(employeeTerritory);
            _dbcontext.SaveChanges();
            return employeeTerritory;
        }

        public void DeleteEmployeeTerritory(long id)
        {
            var employeeTerritory = _dbcontext.EmployeeTerritories.SingleOrDefault(et => et.EmployeeId == id);
            _dbcontext.Remove(employeeTerritory);
            _dbcontext.SaveChanges();
        }


    }
}