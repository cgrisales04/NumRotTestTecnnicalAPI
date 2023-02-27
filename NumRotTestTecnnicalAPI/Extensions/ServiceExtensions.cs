using Microsoft.EntityFrameworkCore;
using NumRotTestTecnnicalAPI.Persistence.Entity;
using NumRotTestTecnnicalAPI.Persistence.Repository.Wrapper;

namespace NumRotTestTecnnicalAPI.Extensions
{
    public static class ServiceExtensions {
        public static void ConfigureRepositoryWrapper(this IServiceCollection services) {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }

        public static void ConfigureIISIntegration(this IServiceCollection services) {
            services.Configure<IISOptions>(options =>
            {
            });
        }

        public static void ConfigureCors(this IServiceCollection services) {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }

        public static void ConfigureMySqlContext(this IServiceCollection services, IConfiguration config) {
            var connectionString = config["mysqlconnection:connectionString"];
            services.AddDbContext<RepositoryContext>(o => o.UseMySql(connectionString,
                MySqlServerVersion.LatestSupportedServerVersion));
        }
    }
}
