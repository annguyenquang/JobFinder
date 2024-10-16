using JobFinder.Core.Entity;

namespace JobFinder.DataAccess.Seed
{
    public class DataSeed
    {
        public static IEnumerable<Metadata> GetMetadataSeeds()
        {

            IEnumerable<Metadata> initialJobTypeMetadatas = [
                new Metadata{ Id= Guid.NewGuid(), Type=0, Value="{data: \"Fulltime\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=0, Value="{data: \"PartTime\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=0, Value="{data: \"Internship\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=0, Value="{data: \"Freelance\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=0, Value="{data: \"Contract\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=0, Value="{data: \"Daily\"}"},
                ];
            IEnumerable<Metadata> initialWorkArrangementMetadatas = [
                new Metadata{ Id= Guid.NewGuid(), Type=1, Value="{data: \"Onsite\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=1, Value="{data: \"Remote/WFH\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=1, Value="{data: \"Hybrid\"}"},
                ];
            IEnumerable<Metadata> initialExperienceMetadatas = [
                new Metadata{ Id= Guid.NewGuid(), Type=2, Value="{data: \"FreshGradute\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=2, Value="{data: \"LessThanOneYear\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=2, Value="{data: \"OneToThreeYears\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=2, Value="{data: \"ThreeToFiveYears\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=2, Value="{data: \"FiveToTenYears\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=2, Value="{data: \"MoreThanTenYears\"}"},
                ];
            
            IEnumerable<Metadata> initialEducationLevelMetadatas = [
                new Metadata{ Id= Guid.NewGuid(), Type=3, Value="{data: \"PrimarySchool\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=3, Value="{data: \"SecondarySchool\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=3, Value="{data: \"SeniorOrVocationalHighSchool\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=3, Value="{data: \"Diploma\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=3, Value="{data: \"CollegeDegree\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=3, Value="{data: \"BachelorDegree\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=3, Value="{data: \"MasterDegree\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=3, Value="{data: \"Doctorate\"}"},
                ];
            IEnumerable<Metadata> initialGenderMetadatas = [
                new Metadata{ Id= Guid.NewGuid(), Type=4, Value="{data: \"Male\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=4, Value="{data: \"Female\"}"},
                new Metadata{ Id= Guid.NewGuid(), Type=4, Value="{data: \"Others\"}"},
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
