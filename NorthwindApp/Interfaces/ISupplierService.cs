using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;

namespace NorthwindApp.Interfaces
{
    public interface ISupplierService
    {
        IEnumerable<SupplierDto> GetSupplierDtos();
        SupplierDto GetSupplierDto(long id);
        SupplierDto AddSupplierDto(CreateNewSupplierDto dto);
        void DeleteSupplierDto(long id);
    }
}