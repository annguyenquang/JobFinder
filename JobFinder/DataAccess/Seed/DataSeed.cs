using JobFinder.Core.Entity;
using JobFinder.Model;

namespace JobFinder.DataAccess.Seed
{
    public class DataSeed
    {
        public static IEnumerable<Company> GetCompanySeeds()
        {
            return new[]
            {
                new Company
                {
                    Id = Guid.Parse("7f9b407b-80e0-4f0c-a301-5a8bbf813b05"),
                    Username = "admin",
                    Password = "$2a$11$hikE.93/ueqzkLgEmg/ZqecSBLDdjFFoAOst74hFbVusInqaD0Zsu",
                    Name = "Tech Corp",
                    EmailContact = "info@techcorp.com",
                    PhoneContact = "123456789",
                    EmployeeCount = 500,
                    Slug = "tech-corp",
                    Address = "123 Tech Lane",
                    Website = "www.techcorp.com",
                    Industry = "Technology",
                    Description = "Tech Corp is a tech corp company.",
                    Logo =
                        "https://images-platform.99static.com/7v8-fjWpezqDYFTxbYGvEE3gnw8=/191x0:1338x1147/500x500/top/smart/99designs-contests-attachments/60/60612/attachment_60612660"
                },
                new Company
                {
                    Id = Guid.Parse("ec7d72b6-e9f4-4c85-bc12-c2db31d5efa7"),
                    Username = "account1",
                    Password = "$2a$11$IZZ6xdXFo09DOlqjYY.bUOcyYxuEk54S6gpROHmYnE3V9OYN43Eae",
                    Name = "Health Inc.",
                    EmailContact = "info@healthinc.com",
                    PhoneContact = "987654321",
                    EmployeeCount = 300,
                    Slug = "health-inc",
                    Address = "456 Health Blvd",
                    Website = "www.healthinc.com",
                    Industry = "Healthcare",
                    Description = "Health Inc. is a health corp company.",
                    Logo =
                        "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRyD1QcAiMJyNvRptFkjJXovZouhRkTEMlazQ&s"
                },
                new Company
                {
                    Id = Guid.Parse("ec6aba4a-1b55-412a-a2e7-9ec8b9f16662"),
                    Username = "account2",
                    Password = "$2a$11$IR24pQlXvPNndxyST6tbTumFqbv2hB65pyyJiJKEHOIID4G13neLa",
                    Name = "An Inc.",
                    EmailContact = "info@AnRe.com",
                    PhoneContact = "98765432112",
                    EmployeeCount = 300,
                    Slug = "an-pro-ga",
                    Address = "45688 London",
                    Website = "www.Anrp.com",
                    Industry = "IT",
                    Description = "An Inc. is a an incident company.",
                    Logo =
                        "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsowdkWEAhFe0idqRamO_CAvGutpD1CHKpcA&s"
                },
            };
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

        public static IEnumerable<Job> GetJobSeeds(IEnumerable<Company> companies, IEnumerable<Metadata> metadatas)
        {
            var workArrangements = metadatas.Where(m => m.Type == MetadataType.WorkArrangement).ToList();
            var commitmentTypes = metadatas.Where(m => m.Type == MetadataType.CommitmentType).ToList();
            var genderRequirements = metadatas.Where(m => m.Type == MetadataType.Gender).ToList();
            var educationLevels = metadatas.Where(m => m.Type == MetadataType.Education).ToList();
            var workExperienceLevels = metadatas.Where(m => m.Type == MetadataType.Experience).ToList();

            var company1 = companies.ElementAt(0);
            var company2 = companies.ElementAt(1);
            var company3 = companies.ElementAt(2);

            // Manually create 20 job instances with varied metadata
            return new List<Job>
            {
                new Job
                {
                    Id = Guid.Parse("4c695d62-51f0-4070-a625-c030208dffb7"),
                    Title = "Software Engineer",
                    Description = "Develop and maintain web applications.",
                    Salary = 80000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(3),
                    MinAgeRequirement = 21,
                    MaxAgeRequirement = 35,
                    ProvinceId = 1,
                    DistrictId = 10,
                    WorkArrangementId = workArrangements[0].Id, // Onsite
                    CommitmentTypeId = commitmentTypes[0].Id, // Fulltime
                    GenderRequirementId = genderRequirements[0].Id, // Male
                    EducationLevelRequirementId = educationLevels[5].Id, // BachelorDegree
                    WorkExperienceRequirementId = workExperienceLevels[3].Id, // ThreeToFiveYears
                    CompanyId = company1.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("5540bd1d-b228-410e-8fbf-0842aeda7cb1"),
                    Title = "Data Analyst",
                    Description = "Analyze large datasets to generate business insights.",
                    Salary = 60000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(2),
                    MinAgeRequirement = 23,
                    MaxAgeRequirement = 40,
                    ProvinceId = 2,
                    DistrictId = 15,
                    WorkArrangementId = workArrangements[1].Id, // Remote/WFH
                    CommitmentTypeId = commitmentTypes[1].Id, // PartTime
                    GenderRequirementId = genderRequirements[1].Id, // Female
                    EducationLevelRequirementId = educationLevels[6].Id, // MasterDegree
                    WorkExperienceRequirementId = workExperienceLevels[4].Id, // FiveToTenYears
                    CompanyId = company2.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("571827fa-78f4-4192-ad3b-06bb014309c2"),
                    Title = "Product Manager",
                    Description = "Oversee product development lifecycle.",
                    Salary = 95000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(4),
                    MinAgeRequirement = 28,
                    MaxAgeRequirement = 45,
                    ProvinceId = 3,
                    DistrictId = 20,
                    WorkArrangementId = workArrangements[2].Id, // Hybrid
                    CommitmentTypeId = commitmentTypes[0].Id, // Fulltime
                    GenderRequirementId = genderRequirements[2].Id, // Others
                    EducationLevelRequirementId = educationLevels[4].Id, // CollegeDegree
                    WorkExperienceRequirementId = workExperienceLevels[5].Id, // MoreThanTenYears
                    CompanyId = company3.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("ca01ec6a-8d39-4e00-ab98-6c3f9a2e0b1e"),
                    Title = "UX Designer",
                    Description = "Design intuitive user interfaces.",
                    Salary = 70000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(3),
                    MinAgeRequirement = 24,
                    MaxAgeRequirement = 38,
                    ProvinceId = 4,
                    DistrictId = 25,
                    WorkArrangementId = workArrangements[0].Id, // Onsite
                    CommitmentTypeId = commitmentTypes[4].Id, // Contract
                    GenderRequirementId = genderRequirements[0].Id, // Male
                    EducationLevelRequirementId = educationLevels[5].Id, // BachelorDegree
                    WorkExperienceRequirementId = workExperienceLevels[2].Id, // OneToThreeYears
                    CompanyId = company1.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("c3d3aa6b-ac70-4aa9-a8c2-88b3e0581d87"),
                    Title = "Software Engineer",
                    Description = "Develop and maintain web applications.",
                    Salary = 80000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(3),
                    MinAgeRequirement = 21,
                    MaxAgeRequirement = 35,
                    ProvinceId = 1,
                    DistrictId = 10,
                    WorkArrangementId = workArrangements[0].Id, // Onsite
                    CommitmentTypeId = commitmentTypes[0].Id, // Fulltime
                    GenderRequirementId = genderRequirements[0].Id, // Male
                    EducationLevelRequirementId = educationLevels[5].Id, // BachelorDegree
                    WorkExperienceRequirementId = workExperienceLevels[3].Id, // ThreeToFiveYears
                    CompanyId = company1.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("9127e8f9-a91c-4dca-8008-3cb7a8dcfb22"),
                    Title = "Data Analyst",
                    Description = "Analyze large datasets to generate business insights.",
                    Salary = 60000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(2),
                    MinAgeRequirement = 23,
                    MaxAgeRequirement = 40,
                    ProvinceId = 2,
                    DistrictId = 15,
                    WorkArrangementId = workArrangements[1].Id, // Remote/WFH
                    CommitmentTypeId = commitmentTypes[1].Id, // PartTime
                    GenderRequirementId = genderRequirements[1].Id, // Female
                    EducationLevelRequirementId = educationLevels[6].Id, // MasterDegree
                    WorkExperienceRequirementId = workExperienceLevels[4].Id, // FiveToTenYears
                    CompanyId = company2.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("def969c3-e7ad-4f71-9907-2c0d594d3ecb"),
                    Title = "Product Manager",
                    Description = "Oversee product development lifecycle.",
                    Salary = 95000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(4),
                    MinAgeRequirement = 28,
                    MaxAgeRequirement = 45,
                    ProvinceId = 3,
                    DistrictId = 20,
                    WorkArrangementId = workArrangements[2].Id, // Hybrid
                    CommitmentTypeId = commitmentTypes[0].Id, // Fulltime
                    GenderRequirementId = genderRequirements[2].Id, // Others
                    EducationLevelRequirementId = educationLevels[4].Id, // CollegeDegree
                    WorkExperienceRequirementId = workExperienceLevels[5].Id, // MoreThanTenYears
                    CompanyId = company3.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("22aadfc7-6022-4f15-ac49-13fa33f8afbe"),
                    Title = "Network Engineer",
                    Description = "Manage and maintain network infrastructure.",
                    Salary = 85000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(3),
                    MinAgeRequirement = 25,
                    MaxAgeRequirement = 40,
                    ProvinceId = 4,
                    DistrictId = 21,
                    WorkArrangementId = workArrangements[0].Id, // Onsite
                    CommitmentTypeId = commitmentTypes[4].Id, // Contract
                    GenderRequirementId = genderRequirements[0].Id, // Male
                    EducationLevelRequirementId = educationLevels[5].Id, // BachelorDegree
                    WorkExperienceRequirementId = workExperienceLevels[4].Id, // FiveToTenYears
                    CompanyId = company1.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("8845c741-6b0f-4f95-b179-3d007ba28a41"),
                    Title = "Sales Executive",
                    Description = "Build and maintain client relationships.",
                    Salary = 55000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(2),
                    MinAgeRequirement = 23,
                    MaxAgeRequirement = 35,
                    ProvinceId = 5,
                    DistrictId = 30,
                    WorkArrangementId = workArrangements[1].Id, // Remote/WFH
                    CommitmentTypeId = commitmentTypes[2].Id, // Freelance
                    GenderRequirementId = genderRequirements[1].Id, // Female
                    EducationLevelRequirementId = educationLevels[3].Id, // Diploma
                    WorkExperienceRequirementId = workExperienceLevels[2].Id, // OneToThreeYears
                    CompanyId = company2.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("8f31d3d0-dc53-45d6-bccd-fd2d15dacb77"),
                    Title = "Customer Support Specialist",
                    Description = "Provide technical support to clients.",
                    Salary = 45000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(3),
                    MinAgeRequirement = 22,
                    MaxAgeRequirement = 33,
                    ProvinceId = 6,
                    DistrictId = 18,
                    WorkArrangementId = workArrangements[2].Id, // Hybrid
                    CommitmentTypeId = commitmentTypes[1].Id, // PartTime
                    GenderRequirementId = genderRequirements[2].Id, // Others
                    EducationLevelRequirementId = educationLevels[4].Id, // CollegeDegree
                    WorkExperienceRequirementId = workExperienceLevels[0].Id, // FreshGraduate
                    CompanyId = company3.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("fa01ec6a-8d39-4e00-ab98-6c3f9a2e0b1f"),
                    Title = "Front-End Developer",
                    Description = "Develop responsive web interfaces.",
                    Salary = 65000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(5),
                    MinAgeRequirement = 22,
                    MaxAgeRequirement = 35,
                    ProvinceId = 5,
                    DistrictId = 30,
                    WorkArrangementId = workArrangements[0].Id, // Onsite
                    CommitmentTypeId = commitmentTypes[0].Id, // Fulltime
                    GenderRequirementId = genderRequirements[1].Id, // Female
                    EducationLevelRequirementId = educationLevels[5].Id, // BachelorDegree
                    WorkExperienceRequirementId = workExperienceLevels[2].Id, // OneToThreeYears
                    CompanyId = company2.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("a6b3ec6a-1d44-4b00-aa18-7d3f1a2e2f6d"),
                    Title = "Network Engineer",
                    Description = "Manage and troubleshoot network infrastructure.",
                    Salary = 75000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(3),
                    MinAgeRequirement = 25,
                    MaxAgeRequirement = 40,
                    ProvinceId = 6,
                    DistrictId = 35,
                    WorkArrangementId = workArrangements[2].Id, // Hybrid
                    CommitmentTypeId = commitmentTypes[2].Id, // Internship
                    GenderRequirementId = genderRequirements[0].Id, // Male
                    EducationLevelRequirementId = educationLevels[4].Id, // CollegeDegree
                    WorkExperienceRequirementId = workExperienceLevels[1].Id, // LessThanOneYear
                    CompanyId = company3.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("c3e8ff99-9f1a-4e4e-aaa4-4d1c8e5e3b5a"),
                    Title = "Data Scientist",
                    Description = "Develop data models and predictive analytics.",
                    Salary = 95000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(6),
                    MinAgeRequirement = 26,
                    MaxAgeRequirement = 45,
                    ProvinceId = 7,
                    DistrictId = 40,
                    WorkArrangementId = workArrangements[1].Id, // Remote/WFH
                    CommitmentTypeId = commitmentTypes[0].Id, // Fulltime
                    GenderRequirementId = genderRequirements[2].Id, // Others
                    EducationLevelRequirementId = educationLevels[6].Id, // MasterDegree
                    WorkExperienceRequirementId = workExperienceLevels[3].Id, // ThreeToFiveYears
                    CompanyId = company1.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("5f9c2d8f-a7f2-45a4-8e4a-90b8f7a03b3e"),
                    Title = "Backend Developer",
                    Description = "Build and maintain server-side applications.",
                    Salary = 78000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(2),
                    MinAgeRequirement = 24,
                    MaxAgeRequirement = 38,
                    ProvinceId = 8,
                    DistrictId = 45,
                    WorkArrangementId = workArrangements[2].Id, // Hybrid
                    CommitmentTypeId = commitmentTypes[4].Id, // Contract
                    GenderRequirementId = genderRequirements[1].Id, // Female
                    EducationLevelRequirementId = educationLevels[5].Id, // BachelorDegree
                    WorkExperienceRequirementId = workExperienceLevels[2].Id, // OneToThreeYears
                    CompanyId = company2.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("8c78bbac-4a5e-49ab-aafb-5a6c3f0c4b5d"),
                    Title = "Machine Learning Engineer",
                    Description = "Implement machine learning models for automation.",
                    Salary = 120000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(7),
                    MinAgeRequirement = 27,
                    MaxAgeRequirement = 50,
                    ProvinceId = 9,
                    DistrictId = 50,
                    WorkArrangementId = workArrangements[1].Id, // Remote/WFH
                    CommitmentTypeId = commitmentTypes[1].Id, // PartTime
                    GenderRequirementId = genderRequirements[0].Id, // Male
                    EducationLevelRequirementId = educationLevels[6].Id, // MasterDegree
                    WorkExperienceRequirementId = workExperienceLevels[4].Id, // FiveToTenYears
                    CompanyId = company3.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("3d6b9f9b-6f2d-4b4a-b4c7-2c8b5f4e1b4e"),
                    Title = "Project Manager",
                    Description = "Coordinate and oversee project delivery.",
                    Salary = 90000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(3),
                    MinAgeRequirement = 30,
                    MaxAgeRequirement = 50,
                    ProvinceId = 10,
                    DistrictId = 55,
                    WorkArrangementId = workArrangements[0].Id, // Onsite
                    CommitmentTypeId = commitmentTypes[4].Id, // Contract
                    GenderRequirementId = genderRequirements[2].Id, // Others
                    EducationLevelRequirementId = educationLevels[5].Id, // BachelorDegree
                    WorkExperienceRequirementId = workExperienceLevels[5].Id, // MoreThanTenYears
                    CompanyId = company1.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("4b3dff90-4d8a-4cbb-a3e8-6c7e5a4d3c4a"),
                    Title = "Content Strategist",
                    Description = "Plan and manage content creation.",
                    Salary = 55000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(2),
                    MinAgeRequirement = 21,
                    MaxAgeRequirement = 35,
                    ProvinceId = 11,
                    DistrictId = 60,
                    WorkArrangementId = workArrangements[1].Id, // Remote/WFH
                    CommitmentTypeId = commitmentTypes[1].Id, // PartTime
                    GenderRequirementId = genderRequirements[1].Id, // Female
                    EducationLevelRequirementId = educationLevels[3].Id, // SeniorOrVocationalHighSchool
                    WorkExperienceRequirementId = workExperienceLevels[1].Id, // LessThanOneYear
                    CompanyId = company2.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("af7bcf34-a92d-4b2b-9937-3e6b7f4f2c6d"),
                    Title = "Quality Assurance Engineer",
                    Description = "Ensure software quality through testing.",
                    Salary = 70000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(4),
                    MinAgeRequirement = 24,
                    MaxAgeRequirement = 39,
                    ProvinceId = 12,
                    DistrictId = 65,
                    WorkArrangementId = workArrangements[2].Id, // Hybrid
                    CommitmentTypeId = commitmentTypes[0].Id, // Fulltime
                    GenderRequirementId = genderRequirements[0].Id, // Male
                    EducationLevelRequirementId = educationLevels[5].Id, // BachelorDegree
                    WorkExperienceRequirementId = workExperienceLevels[2].Id, // OneToThreeYears
                    CompanyId = company3.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("1c8a7d6b-2d7f-4c2b-a9c5-8b3e9f6f2d8b"),
                    Title = "Marketing Specialist",
                    Description = "Develop marketing strategies to drive growth.",
                    Salary = 60000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(3),
                    MinAgeRequirement = 23,
                    MaxAgeRequirement = 37,
                    ProvinceId = 13,
                    DistrictId = 70,
                    WorkArrangementId = workArrangements[1].Id, // Remote/WFH
                    CommitmentTypeId = commitmentTypes[3].Id, // Freelance
                    GenderRequirementId = genderRequirements[1].Id, // Female
                    EducationLevelRequirementId = educationLevels[4].Id, // CollegeDegree
                    WorkExperienceRequirementId = workExperienceLevels[2].Id, // OneToThreeYears
                    CompanyId = company1.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("b3f9d8c7-a1f4-4e3d-b7c2-7e3f9a4f1c5d"),
                    Title = "Financial Analyst",
                    Description = "Analyze financial data to aid in decision-making.",
                    Salary = 85000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(5),
                    MinAgeRequirement = 27,
                    MaxAgeRequirement = 45,
                    ProvinceId = 14,
                    DistrictId = 75,
                    WorkArrangementId = workArrangements[0].Id, // Onsite
                    CommitmentTypeId = commitmentTypes[4].Id, // Contract
                    GenderRequirementId = genderRequirements[2].Id, // Others
                    EducationLevelRequirementId = educationLevels[6].Id, // MasterDegree
                    WorkExperienceRequirementId = workExperienceLevels[4].Id, // FiveToTenYears
                    CompanyId = company2.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("dd6b2a14-0f8b-41a8-ae5d-53de0a92d764"),
                    Title = "Graphic Designer",
                    Description = "Create visual content for digital and print media.",
                    Salary = 60000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(4),
                    MinAgeRequirement = 22,
                    MaxAgeRequirement = 35,
                    ProvinceId = 15,
                    DistrictId = 80,
                    WorkArrangementId = workArrangements[1].Id, // Remote/WFH
                    CommitmentTypeId = commitmentTypes[0].Id, // Fulltime
                    GenderRequirementId = genderRequirements[1].Id, // Female
                    EducationLevelRequirementId = educationLevels[5].Id, // BachelorDegree
                    WorkExperienceRequirementId = workExperienceLevels[2].Id, // OneToThreeYears
                    CompanyId = company1.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("f07a1be4-bd6d-4c2d-9537-303e0c7a5dcf"),
                    Title = "DevOps Engineer",
                    Description = "Implement CI/CD processes for efficient development.",
                    Salary = 95000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(3),
                    MinAgeRequirement = 26,
                    MaxAgeRequirement = 45,
                    ProvinceId = 16,
                    DistrictId = 85,
                    WorkArrangementId = workArrangements[0].Id, // Onsite
                    CommitmentTypeId = commitmentTypes[1].Id, // PartTime
                    GenderRequirementId = genderRequirements[0].Id, // Male
                    EducationLevelRequirementId = educationLevels[6].Id, // MasterDegree
                    WorkExperienceRequirementId = workExperienceLevels[3].Id, // ThreeToFiveYears
                    CompanyId = company2.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("17e0cd7e-5887-44e2-bf2a-cd1b1f631f76"),
                    Title = "UI/UX Designer",
                    Description = "Design user interfaces and enhance user experience.",
                    Salary = 70000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(5),
                    MinAgeRequirement = 24,
                    MaxAgeRequirement = 38,
                    ProvinceId = 17,
                    DistrictId = 90,
                    WorkArrangementId = workArrangements[1].Id, // Remote/WFH
                    CommitmentTypeId = commitmentTypes[0].Id, // Fulltime
                    GenderRequirementId = genderRequirements[1].Id, // Female
                    EducationLevelRequirementId = educationLevels[5].Id, // BachelorDegree
                    WorkExperienceRequirementId = workExperienceLevels[2].Id, // OneToThreeYears
                    CompanyId = company3.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("1d41e60a-ffb5-4039-b4b6-3e25e68d0f2c"),
                    Title = "Cybersecurity Analyst",
                    Description = "Protect an organization's systems from security threats.",
                    Salary = 90000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(6),
                    MinAgeRequirement = 27,
                    MaxAgeRequirement = 45,
                    ProvinceId = 18,
                    DistrictId = 95,
                    WorkArrangementId = workArrangements[2].Id, // Hybrid
                    CommitmentTypeId = commitmentTypes[0].Id, // Fulltime
                    GenderRequirementId = genderRequirements[2].Id, // Others
                    EducationLevelRequirementId = educationLevels[6].Id, // MasterDegree
                    WorkExperienceRequirementId = workExperienceLevels[4].Id, // FiveToTenYears
                    CompanyId = company1.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("d0d69bba-c6c0-4e1e-b8a1-9b4b44e69b93"),
                    Title = "Database Administrator",
                    Description = "Manage and optimize database systems.",
                    Salary = 80000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(2),
                    MinAgeRequirement = 28,
                    MaxAgeRequirement = 50,
                    ProvinceId = 19,
                    DistrictId = 100,
                    WorkArrangementId = workArrangements[0].Id, // Onsite
                    CommitmentTypeId = commitmentTypes[4].Id, // Contract
                    GenderRequirementId = genderRequirements[1].Id, // Female
                    EducationLevelRequirementId = educationLevels[5].Id, // BachelorDegree
                    WorkExperienceRequirementId = workExperienceLevels[3].Id, // ThreeToFiveYears
                    CompanyId = company2.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("1b9a3a57-5a94-4cc3-9af1-0380d074dd65"),
                    Title = "System Administrator",
                    Description = "Ensure network and system performance and security.",
                    Salary = 75000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(3),
                    MinAgeRequirement = 25,
                    MaxAgeRequirement = 45,
                    ProvinceId = 20,
                    DistrictId = 105,
                    WorkArrangementId = workArrangements[1].Id, // Remote/WFH
                    CommitmentTypeId = commitmentTypes[0].Id, // Fulltime
                    GenderRequirementId = genderRequirements[0].Id, // Male
                    EducationLevelRequirementId = educationLevels[6].Id, // MasterDegree
                    WorkExperienceRequirementId = workExperienceLevels[2].Id, // OneToThreeYears
                    CompanyId = company3.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("82cfed84-d067-4d70-bef9-f08b0636a6b0"),
                    Title = "SEO Specialist",
                    Description = "Optimize website content for search engines.",
                    Salary = 55000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(4),
                    MinAgeRequirement = 21,
                    MaxAgeRequirement = 34,
                    ProvinceId = 21,
                    DistrictId = 110,
                    WorkArrangementId = workArrangements[0].Id, // Onsite
                    CommitmentTypeId = commitmentTypes[1].Id, // PartTime
                    GenderRequirementId = genderRequirements[1].Id, // Female
                    EducationLevelRequirementId = educationLevels[5].Id, // BachelorDegree
                    WorkExperienceRequirementId = workExperienceLevels[1].Id, // LessThanOneYear
                    CompanyId = company2.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("df024b07-216f-41d7-b79b-25eb8f28762d"),
                    Title = "Business Analyst",
                    Description = "Analyze business processes and provide solutions.",
                    Salary = 70000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(5),
                    MinAgeRequirement = 26,
                    MaxAgeRequirement = 44,
                    ProvinceId = 22,
                    DistrictId = 115,
                    WorkArrangementId = workArrangements[2].Id, // Hybrid
                    CommitmentTypeId = commitmentTypes[0].Id, // Fulltime
                    GenderRequirementId = genderRequirements[2].Id, // Others
                    EducationLevelRequirementId = educationLevels[4].Id, // CollegeDegree
                    WorkExperienceRequirementId = workExperienceLevels[2].Id, // OneToThreeYears
                    CompanyId = company3.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("c8e2c78e-f68e-4c7e-a22f-5c81b4b5a8b0"),
                    Title = "Sales Manager",
                    Description = "Lead sales team to achieve targets.",
                    Salary = 95000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(6),
                    MinAgeRequirement = 28,
                    MaxAgeRequirement = 50,
                    ProvinceId = 23,
                    DistrictId = 120,
                    WorkArrangementId = workArrangements[1].Id, // Remote/WFH
                    CommitmentTypeId = commitmentTypes[4].Id, // Contract
                    GenderRequirementId = genderRequirements[1].Id, // Female
                    EducationLevelRequirementId = educationLevels[6].Id, // MasterDegree
                    WorkExperienceRequirementId = workExperienceLevels[4].Id, // FiveToTenYears
                    CompanyId = company1.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("6f0e2a6f-54d7-493c-bcb4-8f5eeb2fba1b"),
                    Title = "Marketing Coordinator",
                    Description = "Assist in the development and execution of marketing campaigns.",
                    Salary = 65000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(2),
                    MinAgeRequirement = 23,
                    MaxAgeRequirement = 36,
                    ProvinceId = 24,
                    DistrictId = 125,
                    WorkArrangementId = workArrangements[0].Id, // Onsite
                    CommitmentTypeId = commitmentTypes[0].Id, // Fulltime
                    GenderRequirementId = genderRequirements[0].Id, // Male
                    EducationLevelRequirementId = educationLevels[5].Id, // BachelorDegree
                    WorkExperienceRequirementId = workExperienceLevels[1].Id, // LessThanOneYear
                    CompanyId = company2.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("3d8db2d5-5020-497e-917b-500a1f663c60"),
                    Title = "Project Manager",
                    Description = "Oversee project planning and execution.",
                    Salary = 100000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(5),
                    MinAgeRequirement = 30,
                    MaxAgeRequirement = 50,
                    ProvinceId = 25,
                    DistrictId = 130,
                    WorkArrangementId = workArrangements[2].Id, // Hybrid
                    CommitmentTypeId = commitmentTypes[1].Id, // PartTime
                    GenderRequirementId = genderRequirements[2].Id, // Others
                    EducationLevelRequirementId = educationLevels[6].Id, // MasterDegree
                    WorkExperienceRequirementId = workExperienceLevels[3].Id, // ThreeToFiveYears
                    CompanyId = company3.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("7c7616f2-3c2c-4c5f-9f40-470e78a847c7"),
                    Title = "Content Writer",
                    Description = "Write and edit content for various platforms.",
                    Salary = 50000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(4),
                    MinAgeRequirement = 21,
                    MaxAgeRequirement = 35,
                    ProvinceId = 26,
                    DistrictId = 135,
                    WorkArrangementId = workArrangements[0].Id, // Onsite
                    CommitmentTypeId = commitmentTypes[0].Id, // Fulltime
                    GenderRequirementId = genderRequirements[1].Id, // Female
                    EducationLevelRequirementId = educationLevels[4].Id, // CollegeDegree
                    WorkExperienceRequirementId = workExperienceLevels[1].Id, // LessThanOneYear
                    CompanyId = company1.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Job
                {
                    Id = Guid.Parse("c0a173ff-5be0-4bc9-877b-8d632eeb6da6"),
                    Title = "Web Developer",
                    Description = "Build and maintain websites and web applications.",
                    Salary = 75000,
                    Status = JobStatus.Open,
                    CloseDate = DateTime.Now.AddMonths(3),
                    MinAgeRequirement = 22,
                    MaxAgeRequirement = 40,
                    ProvinceId = 27,
                    DistrictId = 140,
                    WorkArrangementId = workArrangements[1].Id, // Remote/WFH
                    CommitmentTypeId = commitmentTypes[0].Id, // Fulltime
                    GenderRequirementId = genderRequirements[0].Id, // Male
                    EducationLevelRequirementId = educationLevels[5].Id, // BachelorDegree
                    WorkExperienceRequirementId = workExperienceLevels[2].Id, // OneToThreeYears
                    CompanyId = company2.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
            };
        }
    }
}