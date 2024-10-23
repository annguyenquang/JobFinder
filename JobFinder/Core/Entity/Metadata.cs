using JobFinder.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobFinder.Core.Entity
{
    public class Metadata : BaseEntity
    {
        public string Value { get; set; } = string.Empty;
        public MetadataType Type { get; set; }
        [InverseProperty("WorkArrangement")]
        public List<Job> WorkArrangementJobs { get; set; } = new List<Job>();   
        [InverseProperty("CommitmentType")]
        public List<Job> CommitmentTypeJobs { get; set; } = new List<Job>();   
        [InverseProperty("GenderRequirement")]
        public List<Job> GenderRequirementJobs { get; set; } = new List<Job>();   
        [InverseProperty("EducationLevelRequirement")]
        public List<Job> EducationLevelRequirementJobs { get; set; } = new List<Job>();   
        [InverseProperty("WorkExperienceRequirement")]
        public List<Job> WorkExperienceRequirementJobs { get; set; } = new List<Job>();   
    }
}
