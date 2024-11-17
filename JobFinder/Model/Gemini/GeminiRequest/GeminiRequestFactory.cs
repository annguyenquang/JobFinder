namespace JobFinder.Model;

internal sealed class GeminiRequestFactory
{
    public static GeminiRequest CreateRequest(string prompt, GeminiContent systemInstruction = null)
    {
        return new GeminiRequest
        {
            Contents =
            [
                new GeminiContent
                {
                    Role = "user",
                    Parts =
                    [
                        new GeminiPart
                        {
                            Text = prompt
                        }
                    ]
                }
            ],
            SafetySettings = null,
            SystemInstruction = systemInstruction,
            GenerationConfig = new GenerationConfig
            {
                Temperature = 1,
                TopK = 40,
                TopP = 0.95F,
                MaxOutputTokens = 8192,
                StopSequences = null
            }
        };
    }
}