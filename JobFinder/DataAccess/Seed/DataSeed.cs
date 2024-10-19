using JobFinder.Core.Entity;
using JobFinder.Model;

namespace JobFinder.DataAccess.Seed
{
    public class DataSeed
    {
        public static IEnumerable<Metadata> GetMetadataSeeds()
        {

            IEnumerable<Metadata> initialJobTypeMetadatas = [
                new Metadata{ Id= Guid.Parse("540f318e-b42f-4485-9e60-8faa5bf80962"), Type=MetadataType.CommitmentType, Value="{data: \"Fulltime\"}"},
                new Metadata{ Id= Guid.Parse("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), Type=MetadataType.CommitmentType, Value="{data: \"PartTime\"}"},
                new Metadata{ Id= Guid.Parse("3fbef738-ed16-4778-8463-8390444841de"), Type=MetadataType.CommitmentType, Value="{data: \"Internship\"}"},
                new Metadata{ Id= Guid.Parse("26a49bd7-ad8c-40be-8e7c-dd903f7a653e"), Type=MetadataType.CommitmentType, Value="{data: \"Freelance\"}"},
                new Metadata{ Id= Guid.Parse("44b668b2-09ee-499e-af95-73598f9153a2"), Type=MetadataType.CommitmentType, Value="{data: \"Contract\"}"},
                new Metadata{ Id= Guid.Parse("96279c48-1bfe-441d-992e-db86cb3bf315"), Type=MetadataType.CommitmentType, Value="{data: \"Daily\"}"},
                ];
            IEnumerable<Metadata> initialWorkArrangementMetadatas = [
                new Metadata{ Id= Guid.Parse("04a9de34-0869-41b2-87a8-63c20c4ba22a"), Type=MetadataType.WorkArrangement, Value="{data: \"Onsite\"}"},
                new Metadata{ Id= Guid.Parse("376764fa-28ec-4a08-80e3-a6ab407e8601"), Type=MetadataType.WorkArrangement, Value="{data: \"Remote/WFH\"}"},
                new Metadata{ Id= Guid.Parse("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), Type=MetadataType.WorkArrangement, Value="{data: \"Hybrid\"}"},
                ];
            IEnumerable<Metadata> initialExperienceMetadatas = [
                new Metadata{ Id= Guid.Parse("fbce1042-bce0-47a3-92cc-54e3b86eb570"), Type=MetadataType.Experience, Value="{data: \"FreshGradute\"}"},
                new Metadata{ Id= Guid.Parse("4a3e2365-47f4-45d9-b1d4-326d9f2f3203"), Type=MetadataType.Experience, Value="{data: \"LessThanOneYear\"}"},
                new Metadata{ Id= Guid.Parse("cc4121b2-72c2-4226-ad12-24e722b50cc2"), Type=MetadataType.Experience, Value="{data: \"OneToThreeYears\"}"},
                new Metadata{ Id= Guid.Parse("67db1aef-c1b1-4424-8313-774a5dccdb9d"), Type=MetadataType.Experience, Value="{data: \"ThreeToFiveYears\"}"},
                new Metadata{ Id= Guid.Parse("bf38a1b9-dee3-455a-87c1-4e034fe806f7"), Type=MetadataType.Experience, Value="{data: \"FiveToTenYears\"}"},
                new Metadata{ Id= Guid.Parse("646ccd9f-aa2f-413e-8d3e-eb8ab0b14c96"), Type=MetadataType.Experience, Value="{data: \"MoreThanTenYears\"}"},
                ];
            
            IEnumerable<Metadata> initialEducationLevelMetadatas = [
                new Metadata{ Id= Guid.Parse("ceb115a0-3ffe-455c-b24e-9eff074e1ec1"), Type=MetadataType.Education, Value="{data: \"PrimarySchool\"}"},
                new Metadata{ Id= Guid.Parse("c9d2f457-06bf-40ad-9a4a-d6e201888129"), Type=MetadataType.Education, Value="{data: \"SecondarySchool\"}"},
                new Metadata{ Id= Guid.Parse("52e22ea6-7f97-4816-b64a-bfd4aa21cd74"), Type=MetadataType.Education, Value="{data: \"SeniorOrVocationalHighSchool\"}"},
                new Metadata{ Id= Guid.Parse("ebb6a034-ce37-41a4-b1f6-c70f1698c4f2"), Type=MetadataType.Education, Value="{data: \"Diploma\"}"},
                new Metadata{ Id= Guid.Parse("a3fb036a-04fc-4590-b87d-6ed32e2ec692"), Type=MetadataType.Education, Value="{data: \"CollegeDegree\"}"},
                new Metadata{ Id= Guid.Parse("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), Type=MetadataType.Education, Value="{data: \"BachelorDegree\"}"},
                new Metadata{ Id= Guid.Parse("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"), Type=MetadataType.Education, Value="{data: \"MasterDegree\"}"},
                new Metadata{ Id= Guid.Parse("853384de-154c-4187-bf5d-aa684b85736d"), Type=MetadataType.Education, Value="{data: \"Doctorate\"}"},
                ];
            IEnumerable<Metadata> initialGenderMetadatas = [
                new Metadata{ Id= Guid.Parse("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), Type=MetadataType.Gender, Value="{data: \"Male\"}"},
                new Metadata{ Id= Guid.Parse("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), Type=MetadataType.Gender, Value="{data: \"Female\"}"},
                new Metadata{ Id= Guid.Parse("12497687-64b8-4d8e-814a-b7d1d33d3aab"), Type=MetadataType.Gender, Value="{data: \"Others\"}"},
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
