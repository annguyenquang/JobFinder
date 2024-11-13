namespace JobFinder.Model;

public class CreateJobApplicationModel
{
    public Guid UserId { get; set; }
    public Guid JobId { get; set; }
    public IFormFile CVFile { get; set; } = null!;
    public string CoverLetter { get; set; } = string.Empty;
    public string Phonenumber { get; set; } = string.Empty;
}

public class CreateJobApplicationResponseModel : IBaseResponseModel
{
    public Guid Id { get; set; }
}