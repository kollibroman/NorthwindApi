using NorthwindApp.Interfaces;
using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;

namespace NorthwindApp.Services
{
    public class CustomerService : ICustomerService
    {
        public CustomerDto AddCustomer(CreateCustomerDto dto)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(long id)
        {
            throw new NotImplementedException();
        }

        public CustomerDto GetCustomerDto(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerDto> GetCustomerDtos()
        {
            throw new NotImplementedException();
        }
    }
}