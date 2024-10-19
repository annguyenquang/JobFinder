namespace JobFinder.Model;

public class MetadataModel : BaseResponseModel
{
    public MetadataType Type { get; set; }
    public string Value { get; set; } = string.Empty;
}
