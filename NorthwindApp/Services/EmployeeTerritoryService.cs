using AutoMapper;
using NorthwindApp.Interfaces;
using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;
using NorthwindDomain.AutoGen;
using NorthwindDomain.Interfaces;

namespace NorthwindApp.Services
{
    public class EmployeeTerritoryService : IEmployeeTerritoryService
    {
        private readonly IEmployeeTerritoryRepository _repo;
        private readonly IMapper _mapper;
        public EmployeeTerritoryService(IEmployeeTerritoryRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public IEnumerable<EmployeeTerritoryDto> GetEmployeeTerritoryDtos()
        {
            var emplTerr = _repo.GetEmployeeTerritories();
            return _mapper.Map<IEnumerable<EmployeeTerritoryDto>>(emplTerr);
        }
        public EmployeeTerritoryDto GetEmployeeterritoryDto(long id)
        {
            var emplTerr = _repo.GetEmployeeTerritory(id);
            return _mapper.Map<EmployeeTerritoryDto>(emplTerr);
        }

        public EmployeeTerritoryDto AddEmployeeTerritoryDto(CreateNewEmployeeTerritoryDto dto)
        {
            var emplTerr = _mapper.Map<EmployeeTerritory>(dto);
            _repo.CreateEmployeeTerritory(emplTerr);
            return _mapper.Map<EmployeeTerritoryDto>(emplTerr);
        }

        public void DeleteEmployeeTerritoryDto(long id)
        {
            _repo.DeleteEmployeeTerritory(id);
        }

    }
}