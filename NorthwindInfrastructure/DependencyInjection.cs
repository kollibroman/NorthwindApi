using Microsoft.Extensions.DependencyInjection;
using NorthwindDomain.AutoGen;
using NorthwindDomain.Interfaces;
using NorthwindInfrastructure.Repositories;

namespace NorthwindInfrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<Northwind>();

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeTerritoryRepository, EmployeeTerritoryRepository>();
            services.AddScoped<IOrderDetailsRepository, OrderDetailsRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IShipperRepository, ShipperRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            services.AddScoped<ITerritoryRepository, TerritoryRepository>();
            return services;
        }
    }
}