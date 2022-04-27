using Microsoft.OpenApi.Models;

namespace NorthwindWebApi.Installer
{
    public class SwaggerInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwaggerGen(c => 
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "WebAPi", Version = "v1"});
            });
        }
    }
}