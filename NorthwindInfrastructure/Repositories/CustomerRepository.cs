using NorthwindDomain.AutoGen;
using NorthwindDomain.Interfaces;

namespace NorthwindInfrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly Northwind _dbcontext;
        public CustomerRepository(Northwind dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IEnumerable<Customer> GetCustomers()
        {
            return _dbcontext.Customers.ToList();
        }
        public Customer GetCustomer(string id)
        {
            return _dbcontext.Customers.SingleOrDefault(c => c.CustomerId == id);
        }

        public Customer CreateCustomer(Customer customer)
        {
            _dbcontext.Add(customer);
            _dbcontext.SaveChanges();
            return customer;
        }

        public void DeleteCustomer(string id)
        {
            var customer = _dbcontext.Customers.SingleOrDefault(c => c.CustomerId == id);
            _dbcontext.Remove(customer);
            _dbcontext.SaveChanges();
        }

    }
}