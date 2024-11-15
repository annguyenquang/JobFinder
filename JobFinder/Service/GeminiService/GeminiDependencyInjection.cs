using JobFinder.Model;
using Microsoft.Extensions.Options;

namespace JobFinder.Service.GeminiService;

public static class GeminiDependencyInjection
{
    public static void AddGemini(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<GeminiOptions>(configuration.GetSection(GeminiOptions.GeminiOption));

        services.AddScoped<GeminiDelegatingHandler>();

        services.AddHttpClient<IGeminiClient, GeminiClient>(
                (serviceProvider, httpClient) =>
                {
                    var geminiOptions = serviceProvider.GetRequiredService<IOptions<GeminiOptions>>().Value;

                    httpClient.BaseAddress = new Uri(geminiOptions.Url);
                })
            .AddHttpMessageHandler<GeminiDelegatingHandler>();
    }
}