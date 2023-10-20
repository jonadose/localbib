using Application.Contracts.Infrastructure;
using Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;

namespace Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IOpenLibraryService, OpenLibraryService>();
            services.AddHttpClient<IOpenLibraryService, OpenLibraryService>(client =>
            {
                client.BaseAddress = new Uri("https://openlibrary.org/");
            });
            return services;
        }
    }
}
