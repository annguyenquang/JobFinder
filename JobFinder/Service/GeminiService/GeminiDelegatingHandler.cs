using JobFinder.Model;
using Microsoft.Extensions.Options;

namespace JobFinder.Service.GeminiService;

internal sealed class GeminiDelegatingHandler(IOptions<GeminiOptions> geminiOptions) 
    : DelegatingHandler
{
    private readonly GeminiOptions _geminiOptions = geminiOptions.Value;

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        request.Headers.Add("x-google-api-key", $"{_geminiOptions.ApiKey}");
        return base.SendAsync(request, cancellationToken);
    }
}