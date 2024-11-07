namespace JobFinder.Model;

public class MetadataModel : IBaseResponseModel
{
    public MetadataType Type { get; set; }
    public string Value { get; set; } = string.Empty;
    public Guid Id { get; set; }
}
