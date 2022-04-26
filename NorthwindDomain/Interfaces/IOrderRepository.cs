using NorthwindDomain.AutoGen;

namespace NorthwindDomain.Interfaces
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrders();
        Order GetOrder(long id);
        Order CreateOrder(Order order);
        void DeleteOrder(long id);
    }
}