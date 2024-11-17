namespace JobFinder.Model;

public class SuggestibleUserModel 
{
    public IEnumerable<string> Skills { get; set; } = Enumerable.Empty<string>();
    public IEnumerable<string> LatestSearchKeywords { get; set; } = new List<string>();
}