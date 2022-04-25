using AutoMapper;
using NorthwindApp.Models;
using NorthwindDomain.AutoGen;

namespace NorthwindApp.MappingProfiles
{
    public class NorthwindMappingProfile : Profile
    {
        public NorthwindMappingProfile()
        {
           CreateMap<Category, CategoryDto>();
           CreateMap<Customer, CustomerDto>();
           CreateMap<Employee, EmployeeDto>();
           CreateMap<EmployeeTerritory, EmployeeTerritoryDto>();
           CreateMap<OrderDetail, OrderDetailsDto>();
           CreateMap<Order, OrderDto>();
           CreateMap<Product, ProductDto>();
           CreateMap<Shipper, ShipperDto>();
           CreateMap<Supplier, SupplierDto>();
           CreateMap<Territory, TerritoryDto>();
        }
    }
}