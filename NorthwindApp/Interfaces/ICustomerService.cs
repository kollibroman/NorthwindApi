using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;

namespace NorthwindApp.Interfaces
{
    public interface ICustomerService
    {
        IEnumerable<CustomerDto> GetCustomerDtos();
        CustomerDto GetCustomerDto(string id);
        CustomerDto AddCustomer(CreateCustomerDto dto);
        void DeleteCustomer(string id);
    }
}