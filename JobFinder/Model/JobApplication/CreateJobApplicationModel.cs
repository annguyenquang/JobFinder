namespace JobFinder.Model
{
    public class CreateJobApplicationModel
    {
        public Guid UserId { get; set; }
        public Guid JobId { get; set; }
        public IFormFile CVFile { get; set; } = null!;
    }
    public class CreateJobApplicationReponseModel : IBaseResponseModel
    {
        public Guid Id { get; set; }
    }
}
