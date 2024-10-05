using JobFinder.Core.Entity;

namespace JobFinder.Model
{
    public class UpdatePositionModel
    {
        public string? Title { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public double? Salary { get; set; }
        public PositionStatus? Status { get; set; }
        public DateTime? CloseDate { get; set; }
    }
    public class UpdatePositionReponseModel : BaseResponseModel { }
}
