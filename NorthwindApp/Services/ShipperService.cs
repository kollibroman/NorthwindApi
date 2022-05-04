using AutoMapper;
using NorthwindApp.Interfaces;
using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;
using NorthwindDomain.AutoGen;
using NorthwindDomain.Interfaces;

namespace NorthwindApp.Services
{
    public class ShipperService : IShipperService
    {
        private readonly IShipperRepository _repo;
        private readonly IMapper _mapper;
        public ShipperService(IShipperRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public IEnumerable<ShipperDto> GetShipperDtos()
        {
            var shipper = _repo.GetShippers();
            return _mapper.Map<IEnumerable<ShipperDto>>(shipper);
        }
        public ShipperDto GetShipperDto(long id)
        {
            var shipper = _repo.GetShipper(id);
            return _mapper.Map<ShipperDto>(shipper);
        }

        public ShipperDto AddShipperDto(CreateNewShipperDto dto)
        {
            var shipper = _mapper.Map<Shipper>(dto);
            _repo.CreateShipper(shipper);
            return _mapper.Map<ShipperDto>(shipper);
        }

        public void DeleteShipperDto(long id)
        {
            _repo.DeleteShipper(id);
        }

    }
}