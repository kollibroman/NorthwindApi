using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;

namespace NorthwindApp.Interfaces
{
    public interface IOrderDetailsService
    {
        IEnumerable<OrderDetailsDto> GetOrderDetailsDtos();
        OrderDetailsDto GetOrderDetailsDto(long id);
        OrderDetailsDto AddOrderDetailsDto(CreateOrderDetailsDto dto);
        void DeleteOrderDetailsDto(long id);
    }
}