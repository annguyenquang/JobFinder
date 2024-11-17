using System.Text;
using System.Text.Json.Serialization;
using JobFinder.Model;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace JobFinder.Service.GeminiService;

public interface IGeminiClient
{
    public Task<string> GenerateContentAsync(string prompt, 
        CancellationToken cancellationToken, GeminiContent systemInstruction = null);
}
internal sealed class GeminiClient : IGeminiClient
{
    private readonly IOptions<GeminiOptions> _options;
    private readonly HttpClient _httpClient;
    private readonly ILogger<GeminiClient> _logger;
    private readonly JsonSerializerSettings _serializerSettings = new()
    {
        NullValueHandling = NullValueHandling.Ignore,
        ContractResolver = new DefaultContractResolver
        {
            NamingStrategy = new CamelCaseNamingStrategy()
        }
    };

    public GeminiClient(HttpClient httpClient, ILogger<GeminiClient> logger, IOptions<GeminiOptions> options)
    {
        _httpClient = httpClient;
        _logger = logger;
        _options = options;
    }

    public async Task<string> GenerateContentAsync(string prompt,  CancellationToken cancellationToken, GeminiContent systemInstruction = null)
    {
        var requestBody = GeminiRequestFactory.CreateRequest(prompt, systemInstruction);
        var jsonString = JsonConvert.SerializeObject(requestBody, Formatting.None, _serializerSettings);
        var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync(string.Empty, content, cancellationToken);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();
        var geminiResponse = JsonConvert.DeserializeObject<GeminiResponse>(responseBody);

        var geminiResponseText = geminiResponse?.Candidates.FirstOrDefault()?.Content.Parts.FirstOrDefault()?.Text;
        if(geminiResponseText == null)
            throw new Exception("Gemini response is null");
        if (geminiResponseText.StartsWith("```json") && geminiResponseText.EndsWith("```"))
        {
            geminiResponseText = geminiResponseText.Remove(0, "```json".Length);
            geminiResponseText = geminiResponseText.Remove(geminiResponseText.Length - "```".Length);
        }
        return geminiResponseText;
    }
}