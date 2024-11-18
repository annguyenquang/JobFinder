namespace JobFinder.Model;
internal sealed class GenerationConfig
{
    public int Temperature { get; set; }
    public int TopK { get; set; }
    public float TopP { get; set; }
    public int MaxOutputTokens { get; set; }
    public string ResponseMimeType { get; set; } = "text/plain";  
    public List<object>? StopSequences { get; set; }
}