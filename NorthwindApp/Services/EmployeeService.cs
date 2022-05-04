using AutoMapper;
using NorthwindApp.Interfaces;
using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;
using NorthwindDomain.AutoGen;
using NorthwindDomain.Interfaces;

namespace NorthwindApp.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repo;
        private readonly IMapper _mapper;
        public EmployeeService(IEmployeeRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public IEnumerable<EmployeeDto> GetEmployeeDtos()
        {
            var employees = _repo.GetEmployees();
            return _mapper.Map<IEnumerable<EmployeeDto>>(employees);
        }
        public EmployeeDto GetEmployeeDto(long id)
        {
            var employee = _repo.GetEmployee(id);
            return _mapper.Map<EmployeeDto>(employee);
        }

        public EmployeeDto AddEmployee(CreateNewEmployeeDto dto)
        {
            var employee = _mapper.Map<Employee>(dto);
            _repo.CreateEmployee(employee);
            return _mapper.Map<EmployeeDto>(employee);
        }

        public void DeleteEmployee(long id)
        {
            _repo.DeleteEmployee(id);
        }
    }
}