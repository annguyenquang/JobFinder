namespace JobFinder.Model
{
    public class JobApplicationModel
        : IBaseResponseModel
    {
        public JobModel Job { get; set; }
        public UserModel User { get; set; }
        public string CVLink { get; set; } = string.Empty;

        public Guid Id { get; set; }
    }
}
