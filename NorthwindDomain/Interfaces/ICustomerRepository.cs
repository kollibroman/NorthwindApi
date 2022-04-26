using NorthwindDomain.AutoGen;

namespace NorthwindDomain.Interfaces
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomer(string id);
        Customer CreateCustomer(Customer customer);
        void DeleteCustomer(string id);
    }
}