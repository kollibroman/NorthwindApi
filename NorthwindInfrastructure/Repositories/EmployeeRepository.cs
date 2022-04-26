using NorthwindDomain.AutoGen;
using NorthwindDomain.Interfaces;

namespace NorthwindInfrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly Northwind _dbcontext;
        public EmployeeRepository(Northwind dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _dbcontext.Employees.ToList();
        }
        public Employee GetEmployee(long id)
        {
            return _dbcontext.Employees.SingleOrDefault(e => e.EmployeeId == id);
        }
        public Employee CreateEmployee(Employee employee)
        {
            _dbcontext.Add(employee);
            _dbcontext.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(long id)
        {
            var employee = _dbcontext.Employees.SingleOrDefault(e => e.EmployeeId == id);
            _dbcontext.Remove(employee);
            _dbcontext.SaveChanges();
        }


    }
}