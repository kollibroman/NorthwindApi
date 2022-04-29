using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;
using NorthwindDomain.AutoGen;

namespace NorthwindApp.Interfaces
{
    public interface IShipperService
    {
        IEnumerable<ShipperDto> GetShipperDtos();
        ShipperDto GetShipperDto(long id);
        ShipperDto AddShipperDto(CreateNewShipperDto dto);
        void DeleteShipperDto(long id);
    }
}