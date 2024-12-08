using JobFinder.Core.Entity;
using JobFinder.Model;
using Newtonsoft.Json;

namespace JobFinder.DataAccess.Seed
{
    public class DataSeed 
    {
        public static IEnumerable<User> GetUserSeeds()
        {
            return
            [
                new User
                {
                    Id = Guid.Parse("0cc554c2-c577-4a89-8cc1-90724bcbb9fb"),
                    FirstName = "An",
                    LastName = "Nguyen", Email = "an.nguyen@gmail.com", Username = "user1", Password = "$2a$11$FwT.00cm86tbj3/ROPWnLOFAblHj19tmtNy9S2CAc1TFqgM/YPfUO",
                    DateOfBirth = DateOnly.Parse("2003-10-12"),
                    Skills = [".NET", "Java", "Architecture"],
                    Certifications =
                    [
                        new Certification
                        {
                            Name = "TOEIC R&L 855", IssuingOrganization = "IIG Vietnam",
                            IssueDate = new DateOnly(2024, 6, 19), ExpirationDate = new DateOnly(2026, 6, 19)
                        },
                        new Certification
                        {
                            Name = "IELTS 6.5", IssuingOrganization = "IIG Vietnam"
                        },
                        
                    ]
                },
                new User
                {
                    Id = Guid.Parse("789d82a4-e7ea-458b-aacd-039fc2f30fc4"),
                    FirstName = "Chi",
                    LastName = "Nguyen",
                    Email = "chi.nguyen@gmail.com",
                    Username = "user2",
                    Password = "$2y$10$uRRTkqzKKlF5u0Zpq8cjDujsFWyMjmx65oYZc8kO10GiTXpp3Gaxe",
                    DateOfBirth = DateOnly.Parse("2003-10-12"),
                    Skills = ["Marketing", "Digital Marketing", "Communication", "SEO", "AI Technologies"],
                    Certifications =
                    [
                        new Certification
                        {
                            Name = "Google SEO 2024", IssuingOrganization = "Google",
                            IssueDate = new DateOnly(2024, 6, 19), ExpirationDate = new DateOnly(2026, 6, 19)
                        },
                    ]
                }
            ];
        }

        public static IEnumerable<Metadata> GetMetadataSeeds()
        {
            IEnumerable<Metadata> initialCommitmentTypeMetadatas =
            [
                new()
                {
                    Id = Guid.Parse("540f318e-b42f-4485-9e60-8faa5bf80962"), Type = MetadataType.CommitmentType,
                    Value = "{\"data\": \"FullTime\"}"
                },
                new()
                {
                    Id = Guid.Parse("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff"), Type = MetadataType.CommitmentType,
                    Value = "{\"data\": \"PartTime\"}"
                },
                new()
                {
                    Id = Guid.Parse("3fbef738-ed16-4778-8463-8390444841de"), Type = MetadataType.CommitmentType,
                    Value = "{\"data\": \"Internship\"}"
                },
                new()
                {
                    Id = Guid.Parse("26a49bd7-ad8c-40be-8e7c-dd903f7a653e"), Type = MetadataType.CommitmentType,
                    Value = "{\"data\": \"Freelance\"}"
                },
                new()
                {
                    Id = Guid.Parse("44b668b2-09ee-499e-af95-73598f9153a2"), Type = MetadataType.CommitmentType,
                    Value = "{\"data\": \"Contract\"}"
                },
                new()
                {
                    Id = Guid.Parse("96279c48-1bfe-441d-992e-db86cb3bf315"), Type = MetadataType.CommitmentType,
                    Value = "{\"data\": \"Daily\"}"
                },
            ];
            IEnumerable<Metadata> initialWorkArrangementMetadatas =
            [
                new()
                {
                    Id = Guid.Parse("04a9de34-0869-41b2-87a8-63c20c4ba22a"), Type = MetadataType.WorkArrangement,
                    Value = "{\"data\": \"Onsite\"}"
                },
                new()
                {
                    Id = Guid.Parse("376764fa-28ec-4a08-80e3-a6ab407e8601"), Type = MetadataType.WorkArrangement,
                    Value = "{\"data\": \"Remote/WFH\"}"
                },
                new()
                {
                    Id = Guid.Parse("c199da74-c2fb-4381-b093-cf2f1e3e8f06"), Type = MetadataType.WorkArrangement,
                    Value = "{\"data\": \"Hybrid\"}"
                },
            ];
            IEnumerable<Metadata> initialExperienceMetadatas =
            [
                new()
                {
                    Id = Guid.Parse("fbce1042-bce0-47a3-92cc-54e3b86eb570"), Type = MetadataType.Experience,
                    Value = "{\"data\": \"FreshGraduate\"}"
                },
                new()
                {
                    Id = Guid.Parse("4a3e2365-47f4-45d9-b1d4-326d9f2f3203"), Type = MetadataType.Experience,
                    Value = "{\"data\": \"LessThanOneYear\"}"
                },
                new()
                {
                    Id = Guid.Parse("cc4121b2-72c2-4226-ad12-24e722b50cc2"), Type = MetadataType.Experience,
                    Value = "{\"data\": \"OneToThreeYears\"}"
                },
                new()
                {
                    Id = Guid.Parse("67db1aef-c1b1-4424-8313-774a5dccdb9d"), Type = MetadataType.Experience,
                    Value = "{\"data\": \"ThreeToFiveYears\"}"
                },
                new()
                {
                    Id = Guid.Parse("bf38a1b9-dee3-455a-87c1-4e034fe806f7"), Type = MetadataType.Experience,
                    Value = "{\"data\": \"FiveToTenYears\"}"
                },
                new()
                {
                    Id = Guid.Parse("646ccd9f-aa2f-413e-8d3e-eb8ab0b14c96"), Type = MetadataType.Experience,
                    Value = "{\"data\": \"MoreThanTenYears\"}"
                },
            ];

            IEnumerable<Metadata> initialEducationLevelMetadatas =
            [
                new()
                {
                    Id = Guid.Parse("ceb115a0-3ffe-455c-b24e-9eff074e1ec1"), Type = MetadataType.Education,
                    Value = "{\"data\": \"PrimarySchool\"}"
                },
                new()
                {
                    Id = Guid.Parse("c9d2f457-06bf-40ad-9a4a-d6e201888129"), Type = MetadataType.Education,
                    Value = "{\"data\": \"SecondarySchool\"}"
                },
                new()
                {
                    Id = Guid.Parse("52e22ea6-7f97-4816-b64a-bfd4aa21cd74"), Type = MetadataType.Education,
                    Value = "{\"data\": \"SeniorOrVocationalHighSchool\"}"
                },
                new()
                {
                    Id = Guid.Parse("ebb6a034-ce37-41a4-b1f6-c70f1698c4f2"), Type = MetadataType.Education,
                    Value = "{\"data\": \"Diploma\"}"
                },
                new()
                {
                    Id = Guid.Parse("a3fb036a-04fc-4590-b87d-6ed32e2ec692"), Type = MetadataType.Education,
                    Value = "{\"data\": \"CollegeDegree\"}"
                },
                new()
                {
                    Id = Guid.Parse("bc4ecf1e-8841-47f2-86ec-b0c523f03da1"), Type = MetadataType.Education,
                    Value = "{\"data\": \"BachelorDegree\"}"
                },
                new()
                {
                    Id = Guid.Parse("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb"), Type = MetadataType.Education,
                    Value = "{\"data\": \"MasterDegree\"}"
                },
                new()
                {
                    Id = Guid.Parse("853384de-154c-4187-bf5d-aa684b85736d"), Type = MetadataType.Education,
                    Value = "{\"data\": \"Doctorate\"}"
                },
            ];
            IEnumerable<Metadata> initialGenderMetadatas =
            [
                new()
                {
                    Id = Guid.Parse("79685cdb-be26-49cc-b7f9-1fb51686f5ba"), Type = MetadataType.Gender,
                    Value = "{\"data\": \"Male\"}"
                },
                new()
                {
                    Id = Guid.Parse("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6"), Type = MetadataType.Gender,
                    Value = "{\"data\": \"Female\"}"
                },
                new()
                {
                    Id = Guid.Parse("12497687-64b8-4d8e-814a-b7d1d33d3aab"), Type = MetadataType.Gender,
                    Value = "{\"data\": \"Others\"}"
                },
            ];
            return
            [
                ..initialCommitmentTypeMetadatas,
                ..initialWorkArrangementMetadatas,
                ..initialExperienceMetadatas,
                ..initialEducationLevelMetadatas,
                ..initialGenderMetadatas
            ];
        }

        public static IEnumerable<Company> GetCompanySeeds()
        {
            
            var filePath = ".\\DataAccess\\Seed\\companies.json";
            string jsonContent = File.ReadAllText(filePath);
            List<Company> companies = JsonConvert.DeserializeObject<List<Company>>(jsonContent);
            return companies;
        }

        public static IEnumerable<SeedJobModel> GetJobSeeds()
        {
            var filePath = ".\\DataAccess\\Seed\\jobs.json";
            string jsonContent = File.ReadAllText(filePath);
            List<SeedJobModel> jobs = JsonConvert.DeserializeObject<List<SeedJobModel>>(jsonContent);
            return jobs;
        }

    }
}