namespace JobFinder.Model
{
    public class JobApplicationModel
        : IBaseResponseModel
    {
        public Guid JobId { get; set; }
        public Guid UserId { get; set; }
        public string CVLink { get; set; } = string.Empty;
        public string CoverLetter { get; set; } = string.Empty;

        public Guid Id { get; set; }
    }
}
