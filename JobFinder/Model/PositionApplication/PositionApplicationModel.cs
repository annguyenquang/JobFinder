namespace JobFinder.Model
{
    public class PositionApplicationModel
        : BaseResponseModel
    {
        public PositionModel Position { get; set; }
        public UserModel User { get; set; }
        public string CVLink { get; set; } = string.Empty;

    }
}
