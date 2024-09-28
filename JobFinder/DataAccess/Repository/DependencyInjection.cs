using JobFinder.Core.Repository;

namespace JobFinder.DataAccess.Repository
{
    public static class DependencyInjection
    {
        public static void AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IAccountRepository, AccountRepository>();
        }
    }
}
