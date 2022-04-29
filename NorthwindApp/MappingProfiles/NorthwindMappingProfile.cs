using AutoMapper;
using NorthwindApp.Models;
using NorthwindApp.Models.CreateNewDto;
using NorthwindDomain.AutoGen;

namespace NorthwindApp.MappingProfiles
{
    public class NorthwindMappingProfile : Profile
    {
        public NorthwindMappingProfile()
        {
           CreateMap<Category, CategoryDto>();
           CreateMap<Category, CreateCategoryDto>();
        
           CreateMap<Customer, CustomerDto>();
            CreateMap<Customer, CreateCustomerDto>();

           CreateMap<Employee, EmployeeDto>();
            CreateMap<Employee, CreateNewEmployeeDto>();

           CreateMap<EmployeeTerritory, EmployeeTerritoryDto>();
            CreateMap<EmployeeTerritory, CreateNewEmployeeTerritoryDto>();

           CreateMap<OrderDetail, OrderDetailsDto>();
            CreateMap<OrderDetail, CreateOrderDetailsDto>();

           CreateMap<Order, OrderDto>();
            CreateMap<Order, CreateNewOrderDto>();

           CreateMap<Product, ProductDto>();
            CreateMap<Product, CreateNewProductDto>();

           CreateMap<Shipper, ShipperDto>();
            CreateMap<Shipper, CreateNewShipperDto>();

           CreateMap<Supplier, SupplierDto>();
            CreateMap<Supplier, CreateNewSupplierDto>();

           CreateMap<Territory, TerritoryDto>();
            CreateMap<Territory, CreateNewTerritoryDto>();
        }
    }
}