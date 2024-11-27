namespace JobFinder.Model;

public class SuggestibleUserModel 
{
    public Guid UserId { get; set; }
    public IEnumerable<string> AdditionSkills { get; set; } = new List<string>();
    public IEnumerable<string> LatestSearchKeywords { get; set; } = new List<string>();
}