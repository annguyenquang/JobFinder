using JobFinder.Core.Entity;
using JobFinder.Model;

namespace JobFinder.DataAccess.Seed
{
    public class DataSeed
    {
        public static IEnumerable<Metadata> GetMetadataSeeds()
        {

            IEnumerable<Metadata> initialJobTypeMetadatas = [
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.CommitmentType, Value="{data: \"Fulltime\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.CommitmentType, Value="{data: \"PartTime\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.CommitmentType, Value="{data: \"Internship\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.CommitmentType, Value="{data: \"Freelance\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.CommitmentType, Value="{data: \"Contract\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.CommitmentType, Value="{data: \"Daily\"}"},
                ];
            IEnumerable<Metadata> initialWorkArrangementMetadatas = [
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.WorkArrangement, Value="{data: \"Onsite\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.WorkArrangement, Value="{data: \"Remote/WFH\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.WorkArrangement, Value="{data: \"Hybrid\"}"},
                ];
            IEnumerable<Metadata> initialExperienceMetadatas = [
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.Experience, Value="{data: \"FreshGradute\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.Experience, Value="{data: \"LessThanOneYear\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.Experience, Value="{data: \"OneToThreeYears\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.Experience, Value="{data: \"ThreeToFiveYears\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.Experience, Value="{data: \"FiveToTenYears\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.Experience, Value="{data: \"MoreThanTenYears\"}"},
                ];
            
            IEnumerable<Metadata> initialEducationLevelMetadatas = [
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.Education, Value="{data: \"PrimarySchool\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.Education, Value="{data: \"SecondarySchool\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.Education, Value="{data: \"SeniorOrVocationalHighSchool\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.Education, Value="{data: \"Diploma\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.Education, Value="{data: \"CollegeDegree\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.Education, Value="{data: \"BachelorDegree\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.Education, Value="{data: \"MasterDegree\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.Education, Value="{data: \"Doctorate\"}"},
                ];
            IEnumerable<Metadata> initialGenderMetadatas = [
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.Gender, Value="{data: \"Male\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.Gender, Value="{data: \"Female\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=MetadataType.Gender, Value="{data: \"Others\"}"},
                ];
            return [
                ..initialJobTypeMetadatas, 
                ..initialWorkArrangementMetadatas, 
                ..initialExperienceMetadatas,
                ..initialEducationLevelMetadatas,
                ..initialGenderMetadatas
            ];
        }
    }
}
