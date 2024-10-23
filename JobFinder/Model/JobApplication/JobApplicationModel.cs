namespace JobFinder.Model
{
    public class JobApplicationModel
        : BaseResponseModel
    {
        public JobModel Jobs { get; set; }
        public UserModel User { get; set; }
        public string CVLink { get; set; } = string.Empty;

    }
}
