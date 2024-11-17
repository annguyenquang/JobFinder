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
        var abc = JsonConvert.SerializeObject(requestBody, Formatting.None, _serializerSettings);
        var content = new StringContent(JsonConvert.SerializeObject(requestBody, Formatting.None, _serializerSettings), Encoding.UTF8, "application/json");

        string contentStr = "{\"contents\": [\n{\n\"role\":\"user\",\n\"parts\":[\n{\n\"text\": \"INSERT_INPUT_HERE\"\n}\n]\n}\n],\"generationConfig\":{\n\"temperature\":1,\n\"topK\":40,\n\"topP\":0.95,\n\"maxOutputTokens\":8192,\n\"responseMimeType\":\"text/plain\"\n}}";
        HttpContent httpContent = new StringContent(contentStr, Encoding.UTF8, "application/json"); 
        // var response = await _httpClient.PostAsync("https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-pro:generateContent?key=AIzaSyDUAq3wwNg9jwEVBFjQiL5Wuai_0hvn-4E", 
        //     httpContent, CancellationToken.None);
        var response = await _httpClient.PostAsync(string.Empty, content, cancellationToken);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();
        Console.WriteLine(responseBody);
        var geminiResponse = JsonConvert.DeserializeObject<GeminiResponse>(responseBody);

        var geminiResponseText = geminiResponse?.Candidates[0].Content.Parts[0].Text;

        return geminiResponseText;
    }

    private async void TestCallAI()
    {
        string url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-pro:generateContent?key=";
        var requestBody = new
        {
            contents = new[]
            {
                new
                {
                    role = "user",
                    parts = new[]
                    {
                        new { text = "INSERT_INPUT_HERE" }
                    }
                }
            },
            generationConfig = new
            {
                temperature = 1,
                topK = 40,
                topP = 0.95,
                maxOutputTokens = 8192,
                responseMimeType = "text/plain"
            }
        };
        string jsonContent = System.Text.Json.JsonSerializer.Serialize(requestBody);
        var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");
        try
        {
            var client = new HttpClient();
            // Send POST request
            HttpResponseMessage response = await client.PostAsync(url, httpContent);
            response.EnsureSuccessStatusCode(); // Throw if not a success code.

            // Read and print the response
            string responseContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Response:");
            Console.WriteLine(responseContent);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        
    }
}