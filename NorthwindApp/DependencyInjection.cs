using System.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using NorthwindApp.Interfaces;
using NorthwindApp.Services;

namespace NorthwindApp
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApp(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IEmployeeTerritoryService, EmployeeTerritoryService>();
            services.AddScoped<IOrderDetailsService, OrderDetailsService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IShipperService, ShipperService>();
            services.AddScoped<ISupplierService, SupplierService>();
            services.AddScoped<ITerritoryService, TerritoryService>();

            return services;
        }
    }
}