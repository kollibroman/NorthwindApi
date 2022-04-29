using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;
using NorthwindDomain.AutoGen;

namespace NorthwindApp.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<OrderDto> GetOrderDtos();
        OrderDto GetOrderDto();
        OrderDto AddOrderDto(CreateNewOrderDto dto);
        void DeleteOrder(long id);
    }
}