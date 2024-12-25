using JobFinder.Model.Enums;

namespace JobFinder.Model;

public class UpdateJobApplicationModelParam
{
   public Guid JobApplicationId { get; set; }
   public JobApplicationState State { get; set; }
}