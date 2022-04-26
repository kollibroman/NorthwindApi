using NorthwindDomain.AutoGen;

namespace NorthwindDomain.Interfaces
{
    public interface ISupplierRepository
    {
        IEnumerable<Supplier> GetSuppliers();
        Supplier GetSupplier(long id);
        Supplier CreateSupplier(Supplier supplier);
        void DeleteSupplier(long id);
    }
}