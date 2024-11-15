namespace JobFinder.Model;

internal sealed class GeminiResponse
{
    public Candidate[] Candidates { get; set; }
    public PromptFeedback PromptFeedback { get; set; }
}