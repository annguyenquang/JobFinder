using System.Text;
using JobFinder.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace JobFinder.Service.GeminiService;

public interface IGeminiClient
{
    public Task<string> GenerateContentAsync(string prompt, 
        CancellationToken cancellationToken, GeminiContent[] systemInstruction = null);
}
internal sealed class GeminiClient : IGeminiClient
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<GeminiClient> _logger;
    private readonly JsonSerializerSettings _serializerSettings = new()
    {
        ContractResolver = new DefaultContractResolver
        {
            NamingStrategy = new SnakeCaseNamingStrategy()
        }
    };

    public GeminiClient(HttpClient httpClient, ILogger<GeminiClient> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }

    public async Task<string> GenerateContentAsync(string prompt,  CancellationToken cancellationToken, GeminiContent[] systemInstruction = null)
    {
        var requestBody = GeminiRequestFactory.CreateRequest(prompt, systemInstruction);
        var a = JsonConvert.SerializeObject(requestBody, Formatting.None, _serializerSettings);
        var content = new StringContent(JsonConvert.SerializeObject(requestBody, Formatting.None, _serializerSettings), Encoding.UTF8, "application/json");
            
        var response = await _httpClient.PostAsync("", content, cancellationToken);

        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        var geminiResponse = JsonConvert.DeserializeObject<GeminiResponse>(responseBody);

        var geminiResponseText = geminiResponse?.Candidates[0].Content.Parts[0].Text;

        return geminiResponseText;
    }
}