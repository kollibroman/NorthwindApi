using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;

namespace NorthwindApp.Interfaces
{
    public interface ITerritoryService
    {
        IEnumerable<TerritoryDto> GetTerritoryDtos();
        TerritoryDto GetTerritoryDto(string id);
        TerritoryDto AddTerritoryDto(CreateNewTerritoryDto dto);
        void DeleteTerritoryDto(string id);
    }
}