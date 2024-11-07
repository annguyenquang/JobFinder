using JobFinder.Service.StorageService;

namespace JobFinder.Service
{
    public static class DependencyInjection
    {
        public static void AddService(this IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IJobService, JobService>();
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IStorageService, AzureStorageService>();
            services.AddScoped<IJobApplicationService, JobApplicationService>();
            services.AddScoped<IMetadataService, MetadataService>();
            services.AddScoped<IJwtService, JwtService>();
        }
    }
}
