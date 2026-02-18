using Microsoft.Extensions.DependencyInjection;
using Singleton.Domain.Abstractions;
using Singleton.Infra.Services;

namespace Singleton.Console.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void AddServices(this IServiceCollection services) 
        {
            services.AddTransient<IApiService, ApiService>();
            services.AddTransient<IDatabaseService, DatabaseService>();
            services.AddTransient<ILoggingService, LoggingService>();
            services.AddTransient<ICacheService, CacheService>();
        }
    }
}
