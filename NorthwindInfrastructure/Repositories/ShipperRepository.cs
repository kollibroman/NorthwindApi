using NorthwindDomain.AutoGen;
using NorthwindDomain.Interfaces;

namespace NorthwindInfrastructure.Repositories
{
    public class ShipperRepository : IShipperRepository
    {
        private readonly Northwind _dbcontext;
        public ShipperRepository(Northwind dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public IEnumerable<Shipper> GetShippers()
        {
            return _dbcontext.Shippers.ToList();
        }
        public Shipper GetShipper(long id)
        {
            return _dbcontext.Shippers.SingleOrDefault(s => s.ShipperId == id);
        }

        public Shipper CreateShipper(Shipper shipper)
        {
            _dbcontext.Add(shipper);
            _dbcontext.SaveChanges();
            return shipper;
        }

        public void DeleteShipper(long id)
        {
            var shipper = _dbcontext.Shippers.SingleOrDefault(s => s.ShipperId == id);
            _dbcontext.Remove(shipper);
            _dbcontext.SaveChanges();
        }

    }
}