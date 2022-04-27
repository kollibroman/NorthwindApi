using NorthwindApp;
using NorthwindInfrastructure;

namespace NorthwindWebApi.Installer
{
    public class MvcInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();

            services.AddInfrastructure();
            services.AddApp();
            services.AddAutoMapper(this.GetType().Assembly);
        }
    }
}