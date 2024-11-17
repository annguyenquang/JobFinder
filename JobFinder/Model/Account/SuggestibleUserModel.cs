namespace JobFinder.Model;

public class SuggestibleUserModel : UserModel
{
    public IEnumerable<string> LatestSearchKeyword { get; set; } = new List<string>();
}