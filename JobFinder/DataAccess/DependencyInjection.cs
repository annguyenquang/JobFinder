using JobFinder.Core.Repository;
using JobFinder.DataAccess.Persistent;
using JobFinder.DataAccess.Repository;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.DataAccess
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
                }).EnableSensitiveDataLogging();
            });
        }

        private static void AddRepository(IServiceCollection services)
        {
            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IJobApplicationRepository, JobApplicationRepository>();
            services.AddScoped<IMetadataRepository, MetadataRepository>();
        }
    }
}
