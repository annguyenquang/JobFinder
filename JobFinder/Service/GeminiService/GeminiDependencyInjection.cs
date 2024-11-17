using JobFinder.Model;
using Microsoft.Extensions.Options;

namespace JobFinder.Service.GeminiService;

public static class GeminiDependencyInjection
{
    public static void AddGemini(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<GeminiOptions>(configuration.GetSection(GeminiOptions.GeminiOption));

        services.AddTransient<GeminiDelegatingHandler>();

        services.AddHttpClient<IGeminiClient, GeminiClient>(
            (serviceProvider, httpClient) =>
            {
                var geminiOptions = serviceProvider.GetRequiredService<IOptions<GeminiOptions>>().Value;
                var url = geminiOptions.Url + $"?key={geminiOptions.ApiKey}";
                httpClient.BaseAddress = new Uri(url);
                
            });
        // .AddHttpMessageHandler<GeminiDelegatingHandler>();
    }
}