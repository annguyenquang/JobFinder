namespace JobFinder.Model
{
    public class UserModel : IBaseResponseModel
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateOnly DateOfBirth { get; set; }
        public Guid Id { get; set; }
    }
}
