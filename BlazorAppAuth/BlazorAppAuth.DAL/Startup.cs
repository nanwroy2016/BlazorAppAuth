
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorAppAuth.DAL
{
    public static class Startup
    {
        public static IConfiguration Configuration { get; set; }

        public static IServiceCollection ConfigureDALServices(this IServiceCollection services, IConfiguration configuration)
        {
            //add memory cache provider
            //services.AddMemoryCache();





            return services;
        }
    }
}
