namespace JobFinder.Model;

public record JobSuggestion : ITypeStructureProvider
{
    public Guid JobId { get; init; }
    public string DetailExplanation { get; init; } = string.Empty;
    public static string GetTypeStructure()
    {
        return $$"""
                 {
                    {{nameof(JobId)}}: Guid,
                    {{nameof(DetailExplanation)}}: string,
                 }
                 """;
    }
}