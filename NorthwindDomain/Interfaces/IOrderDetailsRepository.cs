using NorthwindDomain.AutoGen;

namespace NorthwindDomain.Interfaces
{
    public interface IOrderDetailsRepository
    {
        IEnumerable<OrderDetail> GetOrderDetails();
        OrderDetail GetOrderDetail(long id);
        OrderDetail CreateOrderDetail(OrderDetail orderDetail);
        void DeleteOrderDetail(long id);
    }
}