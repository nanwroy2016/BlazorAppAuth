using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using BlazorAppAuth.DAL;


namespace CoreIdentitySample6.BLL
{

    public static class Startup
    {
        public static ILoggerFactory ConsoleLoggerFactory { get; set; }
        public static IConfiguration Configuration { get; set; }
        public static IServiceCollection ConfigureBLLServices(this IServiceCollection services, IConfiguration configuration, bool enableSqlLogging = true, string connStr = "")
        {

            var optionsBuilder = new DbContextOptionsBuilder<BlazorAppAuthContext>();

            if (configuration != null)
            {
                Configuration = configuration;
            }

            if (connStr == "")
            {
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                if (!int.TryParse(configuration.GetConnectionString("TimeOut"), out int timeout))
                    timeout = 600;

                services.AddScoped<DbContext, BlazorAppAuthContext>((sp) => { return new BlazorAppAuthContext(optionsBuilder.Options); });
                optionsBuilder.UseSqlServer(connectionString, sqlServerOptions => { sqlServerOptions.CommandTimeout(timeout); sqlServerOptions.EnableRetryOnFailure(); });
            }

            //services.AddTransient<IUnitOfWork, UnitOfWork>();

            //services.AddTransient<IAspNetUserProvider, AspNetUserProvider>();
            //services.AddTransient<IAspNetUserRepository, AspNetUserRepository>();

            //services.AddTransient<IAspnetMembershipProvider, AspnetMembershipProvider>();
            //services.AddTransient<IAspnetMembershipRepository, AspnetMembershipRepository>();
            services.ConfigureDALServices(configuration);
            return services;
        }
    }


}