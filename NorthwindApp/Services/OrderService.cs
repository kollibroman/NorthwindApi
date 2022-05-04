using AutoMapper;
using NorthwindApp.Interfaces;
using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;
using NorthwindDomain.AutoGen;
using NorthwindDomain.Interfaces;

namespace NorthwindApp.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repo;
        private readonly IMapper _mapper;
        public OrderService(IOrderRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public IEnumerable<OrderDto> GetOrderDtos()
        {
            var orders = _repo.GetOrders();
            return _mapper.Map<IEnumerable<OrderDto>>(orders);
        }
        public OrderDto GetOrderDto(long id)
        {
            var order = _repo.GetOrder(id);
            return _mapper.Map<OrderDto>(order);
        }

        public OrderDto AddOrderDto(CreateNewOrderDto dto)
        {
            var order = _mapper.Map<Order>(dto);
            _repo.CreateOrder(order);
            return _mapper.Map<OrderDto>(order);
        }

        public void DeleteOrder(long id)
        {
            _repo.DeleteOrder(id);
        }

    }
}