using NorthwindDomain.AutoGen;
using NorthwindDomain.Interfaces;

namespace NorthwindInfrastructure.Repositories
{
    public class SupplierRepository :ISupplierRepository
    {
        private readonly Northwind _dbcontext;
        public SupplierRepository(Northwind dbcontext)
        {
            _dbcontext = dbcontext;
        }


        public IEnumerable<Supplier> GetSuppliers()
        {
            return _dbcontext.Suppliers.ToList();
        }
        public Supplier GetSupplier(long id)
        {
            return _dbcontext.Suppliers.SingleOrDefault(s => s.SupplierId == id);
        }
        public Supplier CreateSupplier(Supplier supplier)
        {
            _dbcontext.Add(supplier);
            _dbcontext.SaveChanges();
            return supplier;
        }

        public void DeleteSupplier(long id)
        {
            var supplier = _dbcontext.Suppliers.SingleOrDefault(s => s.SupplierId == id);
            _dbcontext.Remove(supplier);
            _dbcontext.SaveChanges();
        }

    }
}