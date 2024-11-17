namespace JobFinder.Model;

internal sealed class GeminiRequest
{
    public GeminiContent[] Contents { get; set; }
    public GeminiContent SystemInstruction {get; set;}
    public GenerationConfig GenerationConfig { get; set; }
    public SafetySettings[]? SafetySettings { get; set; }
}