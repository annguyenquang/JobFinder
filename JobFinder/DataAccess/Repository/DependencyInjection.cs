using JobFinder.Core.Repository;
using JobFinder.DataAccess.Repository.Persistent;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.DataAccess.Repository
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDatabaseAccess(this IServiceCollection services)
        {
            AddRepository(services);
            AddDatabase(services);
            return services;
        }

        private static void AddDatabase(IServiceCollection services)
        {
            var config = services.BuildServiceProvider().GetService<IConfiguration>();
            services.AddDbContext<DatabaseContext>(options =>
            {
                options.UseSqlServer(connectionString: config.GetConnectionString("DefaultConnection"), opt =>
                {
                    opt.MigrationsAssembly(System.Reflection.Assembly.GetExecutingAssembly().FullName);
                });
            });
        }

        private static void AddRepository(IServiceCollection services)
        {
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IPositionRepository, PositionRepository>();
        }
    }
}
