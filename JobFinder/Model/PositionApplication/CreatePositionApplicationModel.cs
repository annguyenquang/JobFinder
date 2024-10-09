namespace JobFinder.Model
{
    public class CreatePositionApplicationModel
    {
        public Guid UserId { get; set; }
        public Guid PositionId { get; set; }
        public IFormFile CVFile { get; set; } = null!;
    }
    public class CreatePositionApplicationReponseModel : BaseResponseModel { }
}
