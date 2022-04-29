using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;

namespace NorthwindApp.Interfaces
{
    public interface ICustomerService
    {
        IEnumerable<CustomerDto> GetCustomerDtos();
        CustomerDto GetCustomerDto(long id);
        CustomerDto AddCustomer(CreateCustomerDto dto);
        void DeleteCustomer(long id);
    }
}