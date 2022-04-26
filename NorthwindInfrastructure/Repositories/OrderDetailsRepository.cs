using NorthwindDomain.AutoGen;
using NorthwindDomain.Interfaces;

namespace NorthwindInfrastructure.Repositories
{
    public class OrderDetailsRepository : IOrderDetailsRepository
    {
        private readonly Northwind _dbcontext;
        public OrderDetailsRepository(Northwind dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public IEnumerable<OrderDetail> GetOrderDetails()
        {
          return _dbcontext.OrderDetails.ToList();
        }
        public OrderDetail GetOrderDetail(long id)
        {
            return _dbcontext.OrderDetails.SingleOrDefault(o => o.OrderId == id);
        }
        public OrderDetail CreateOrderDetail(OrderDetail orderDetail)
        {
            _dbcontext.Add(orderDetail);
            _dbcontext.SaveChanges();
            return orderDetail;
        }

        public void DeleteOrderDetail(long id)
        {
            var orderDetail = _dbcontext.OrderDetails.SingleOrDefault(o => o.OrderId == id);
            _dbcontext.Remove(orderDetail);
            _dbcontext.SaveChanges();
        }


    }
}