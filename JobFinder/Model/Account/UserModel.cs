namespace JobFinder.Model
{
    public class UserModel : BaseResponseModel
    {
        public Guid AccountId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateOnly DateOfBirth { get; set; }
    }
}
