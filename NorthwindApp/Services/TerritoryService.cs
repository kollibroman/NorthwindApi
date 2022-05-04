using AutoMapper;
using NorthwindApp.Interfaces;
using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;
using NorthwindDomain.AutoGen;
using NorthwindDomain.Interfaces;

namespace NorthwindApp.Services
{
    public class TerritoryService : ITerritoryService
    {
        private readonly ITerritoryRepository _repo;
        private readonly IMapper _mapper;
        public TerritoryService(ITerritoryRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public IEnumerable<TerritoryDto> GetTerritoryDtos()
        {
            var territory = _repo.GetTerritories();
            return _mapper.Map<IEnumerable<TerritoryDto>>(territory);
        }
        public TerritoryDto GetTerritoryDto(string id)
        {
            var territory = _repo.GetTerritory(id);
            return _mapper.Map<TerritoryDto>(territory);
        }

        public TerritoryDto AddTerritoryDto(CreateNewTerritoryDto dto)
        {
            var territory = _mapper.Map<Territory>(dto);
            _repo.CreateTerritory(territory);
            return _mapper.Map<TerritoryDto>(territory);
        }

        public void DeleteTerritoryDto(string id)
        {
            _repo.DeleteTerritory(id);
        }

    }
}