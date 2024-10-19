using JobFinder.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobFinder.Core.Entity
{
    public class Metadata : BaseEntity
    {
        public string Value { get; set; } = string.Empty;
        public MetadataType Type { get; set; }
        [InverseProperty("WorkArrangement")]
        public List<Position> WorkArrangementPositions { get; set; } = new List<Position>();   
        [InverseProperty("CommitmentType")]
        public List<Position> CommitmentTypePositions { get; set; } = new List<Position>();   
        [InverseProperty("GenderRequirement")]
        public List<Position> GenderRequirementPositions { get; set; } = new List<Position>();   
        [InverseProperty("EducationLevelRequirement")]
        public List<Position> EducationLevelRequirementPositions { get; set; } = new List<Position>();   
        [InverseProperty("WorkExperienceRequirement")]
        public List<Position> WorkExperienceRequirementPositions { get; set; } = new List<Position>();   
    }
}
