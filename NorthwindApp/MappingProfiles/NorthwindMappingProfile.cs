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
           CreateMap<CreateCategoryDto, Category>();
        
           CreateMap<Customer, CustomerDto>();
            CreateMap<CreateCustomerDto, Customer>();

           CreateMap<Employee, EmployeeDto>();
            CreateMap<CreateNewEmployeeDto, Employee>();

           CreateMap<EmployeeTerritory, EmployeeTerritoryDto>();
            CreateMap<CreateNewEmployeeTerritoryDto, EmployeeTerritory>();

           CreateMap<OrderDetail, OrderDetailsDto>();
            CreateMap<CreateOrderDetailsDto, OrderDetail>();

           CreateMap<Order, OrderDto>();
            CreateMap<CreateNewOrderDto, Order>();

           CreateMap<Product, ProductDto>();
            CreateMap<CreateNewProductDto, Product>();

           CreateMap<Shipper, ShipperDto>();
            CreateMap<CreateNewShipperDto, Shipper>();

           CreateMap<Supplier, SupplierDto>();
            CreateMap<CreateNewSupplierDto, Supplier>();

           CreateMap<Territory, TerritoryDto>();
            CreateMap<CreateNewTerritoryDto, Territory>();
        }
    }
}