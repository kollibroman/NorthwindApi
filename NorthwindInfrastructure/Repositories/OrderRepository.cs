using NorthwindDomain.AutoGen;
using NorthwindDomain.Interfaces;

namespace NorthwindInfrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly Northwind _dbcontext;
        public OrderRepository(Northwind dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IEnumerable<Order> GetOrders()
        {
            return _dbcontext.Orders.ToList();
        }
        public Order GetOrder(long id)
        {
            return _dbcontext.Orders.SingleOrDefault(o => o.OrderId == id);
        }

        public Order CreateOrder(Order order)
        {
            _dbcontext.Add(order);
            _dbcontext.SaveChanges();
            return order;
        }

        public void DeleteOrder(long id)
        {
            var order = _dbcontext.Orders.SingleOrDefault(o => o.OrderId == id);
            _dbcontext.Remove(order);
            _dbcontext.SaveChanges();
        }

    }
}