using Domain.RepositoryInterface;
using Infrastructure.Repositories;
using Infrastructure.Repositories.Other;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IAccountRepository, AccountRepository>();

            services.AddScoped<IPostRepository, PostRepository>();

            services.AddScoped<ICommentRepository, CommentRepository>();

            services.AddScoped<IOpinionRepository, OpinionRepository>();

            return services;
        }
    }
}
