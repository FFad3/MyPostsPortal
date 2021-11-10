using Application.ServiceInterfaces;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountService>();

            //system reflection
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
