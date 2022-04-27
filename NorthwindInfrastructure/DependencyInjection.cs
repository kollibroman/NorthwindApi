using Microsoft.Extensions.DependencyInjection;
using NorthwindDomain.AutoGen;

namespace NorthwindInfrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<Northwind>();
            return services;
        }
    }
}