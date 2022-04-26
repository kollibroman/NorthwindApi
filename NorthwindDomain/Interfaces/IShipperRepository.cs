using NorthwindDomain.AutoGen;

namespace NorthwindDomain.Interfaces
{
    public interface IShipperRepository
    {
        IEnumerable<Shipper> GetShippers();
        Shipper GetShipper(long id);
        Shipper CreateShipper(Shipper shipper);
        void DeleteShipper(long id);
    }
}