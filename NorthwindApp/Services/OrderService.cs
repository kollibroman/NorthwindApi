using NorthwindApp.Interfaces;
using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;

namespace NorthwindApp.Services
{
    public class OrderService : IOrderService
    {
        public OrderDto AddOrderDto(CreateNewOrderDto dto)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrder(long id)
        {
            throw new NotImplementedException();
        }

        public OrderDto GetOrderDto()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDto> GetOrderDtos()
        {
            throw new NotImplementedException();
        }
    }
}