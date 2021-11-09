using Application;
using Infrastructure;

namespace MyPostsPortalApi.Installer
{
    public class MVCInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration Configuration)
        {
            services.AddInfrastructure();

            services.AddApplication();

            services.AddControllers();
        }
    }
}
