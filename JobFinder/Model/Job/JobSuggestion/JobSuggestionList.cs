namespace JobFinder.Model;

public record JobSuggestionList : ITypeStructureProvider
{
    public string Explanation { get; init; } = string.Empty;

    public IEnumerable<JobSuggestion> Suggestions { get; init; } = [];

    public static string GetTypeStructure()
    {
        return $$"""
                 {
                    {{nameof(Explanation)}}: string,
                    {{nameof(Suggestions)}}: {{JobSuggestion.GetTypeStructure()}}[]
                 }
                 """;
    }
}
