
using JobFinder.Service.StorageService;

namespace JobFinder.Service
{
    public static class DependencyInjection
    {
        public static void AddService(this IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IPositionService, PositionService>();
            services.AddScoped<IFirmService, FirmService>();
            services.AddScoped<IStorageService, AzureStorageService>();
        }
    }
}
