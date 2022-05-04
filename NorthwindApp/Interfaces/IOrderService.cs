using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;
using NorthwindDomain.AutoGen;

namespace NorthwindApp.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<OrderDto> GetOrderDtos();
        OrderDto GetOrderDto(long id);
        OrderDto AddOrderDto(CreateNewOrderDto dto);
        void DeleteOrder(long id);
    }
}