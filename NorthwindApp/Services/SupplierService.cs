using AutoMapper;
using NorthwindApp.Interfaces;
using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;
using NorthwindDomain.AutoGen;
using NorthwindDomain.Interfaces;

namespace NorthwindApp.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _repo;
        private readonly IMapper _mapper;
        public SupplierService(ISupplierRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public IEnumerable<SupplierDto> GetSupplierDtos()
        {
            var suppliers = _repo.GetSuppliers();
            return _mapper.Map<IEnumerable<SupplierDto>>(suppliers);
        }
        public SupplierDto GetSupplierDto(long id)
        {
            var supplier = _repo.GetSupplier(id);
            return _mapper.Map<SupplierDto>(supplier);
        }

        public SupplierDto AddSupplierDto(CreateNewSupplierDto dto)
        {
            var supplier = _mapper.Map<Supplier>(dto);
            _repo.CreateSupplier(supplier);
            return _mapper.Map<SupplierDto>(supplier);
        }

        public void DeleteSupplierDto(long id)
        {
            _repo.DeleteSupplier(id);
        }

    }
}