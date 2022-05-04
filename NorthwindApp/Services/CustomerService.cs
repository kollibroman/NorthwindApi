using AutoMapper;
using NorthwindApp.Interfaces;
using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;
using NorthwindDomain.AutoGen;
using NorthwindDomain.Interfaces;

namespace NorthwindApp.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repo;
        private readonly IMapper _mapper;
        public CustomerService(ICustomerRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public IEnumerable<CustomerDto> GetCustomerDtos()
        {
            var customers = _repo.GetCustomers();
            return _mapper.Map<IEnumerable<CustomerDto>>(customers);
        }
        public CustomerDto GetCustomerDto(string id)
        {
            var customer = _repo.GetCustomer(id);
            return _mapper.Map<CustomerDto>(customer);
        }

        public CustomerDto AddCustomer(CreateCustomerDto dto)
        {
            var customer = _mapper.Map<Customer>(dto);
            _repo.CreateCustomer(customer);
            return _mapper.Map<CustomerDto>(customer);
        }

        public void DeleteCustomer(string id)
        {
            _repo.DeleteCustomer(id);
        }

    }
}