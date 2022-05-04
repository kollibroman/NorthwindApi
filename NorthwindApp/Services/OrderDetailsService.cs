using AutoMapper;
using NorthwindApp.Interfaces;
using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;
using NorthwindDomain.AutoGen;
using NorthwindDomain.Interfaces;

namespace NorthwindApp.Services
{
    public class OrderDetailsService : IOrderDetailsService
    {
        private readonly IOrderDetailsRepository _repo;
        private readonly IMapper _mapper;
        public OrderDetailsService(IOrderDetailsRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public IEnumerable<OrderDetailsDto> GetOrderDetailsDtos()
        {
            var orderdetails = _repo.GetOrderDetails();
            return _mapper.Map<IEnumerable<OrderDetailsDto>>(orderdetails);
        }
        public OrderDetailsDto GetOrderDetailsDto(long id)
        {
            var orderdetails = _repo.GetOrderDetail(id);
            return _mapper.Map<OrderDetailsDto>(orderdetails);
        }

        public OrderDetailsDto AddOrderDetailsDto(CreateOrderDetailsDto dto)
        {
            var orderdetails = _mapper.Map<OrderDetail>(dto);
            _repo.CreateOrderDetail(orderdetails);
            return _mapper.Map<OrderDetailsDto>(orderdetails);
        }

        public void DeleteOrderDetailsDto(long id)
        {
            _repo.DeleteOrderDetail(id);
        }

    }
}