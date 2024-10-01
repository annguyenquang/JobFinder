using JobFinder.Core.Entity;

namespace JobFinder.Model
{
    public class PositionModel : BaseModel
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Salary { get; set; }
        public PositionStatus Status { get; set; }
        public DateTime CloseDate { get; set; }
        public Guid FirmId { get; set; }
    }
}