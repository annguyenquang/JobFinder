using JobFinder.Model;
using JobFinder.Service.GeminiService;
using Newtonsoft.Json;

namespace JobFinder.Service;

public interface IJobSuggestionService
{
    Task<JobSuggestionList> GenerateJobSuggestionListAsync(SuggestibleUserModel suggestibleUser,
        GetJobsByPaginationParams param);
}

public sealed class JobSuggestionService(IGeminiClient _geminiClient, IJobService _jobService, IUserService _userService) : IJobSuggestionService
{
    private GeminiContent DEFAULTSYSTEMSUGGESTION =
        new()
        {
            Role = "user",
            Parts =
            [
                new GeminiPart()
                {
                    Text = $$"""
                           Develop an AI model to suggest suitable job opportunities for users based on multiple attributes within a given job list.
                                                       Each job entry includes key fields such as CommitmentType, WorkArrangement, Experience, Education, and Gender. 
                                                       The AI model should evaluate a user’s profile, recent search history, and preferences to return the most relevant job suggestions. 
                                                       Each job recommendation should be tailored based on the user's preferences and profile information and should respect the values provided below.
                                                       Return the recommendations in the following structure:
                                                       {{JobSuggestionList.GetTypeStructure()}}
                                                       JobSuggestionList.explanation: refer to the skills that user given before.
                                                       Use these mappings for matching job requirements: 
                                                       CommitmentType:
                                                       Contract (ID: "44b668b2-09ee-499e-af95-73598f9153a2")
                                                       Internship ("3fbef738-ed16-4778-8463-8390444841de")
                                                       FullTime ("540f318e-b42f-4485-9e60-8faa5bf80962")
                                                       Daily ("96279c48-1bfe-441d-992e-db86cb3bf315")
                                                       Freelance ("26a49bd7-ad8c-40be-8e7c-dd903f7a653e")
                                                       PartTime ("5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff")
                                                       WorkArrangement:
                                                       Onsite ("04a9de34-0869-41b2-87a8-63c20c4ba22a")
                                                       Remote/WFH ("376764fa-28ec-4a08-80e3-a6ab407e8601")
                                                       Hybrid ("c199da74-c2fb-4381-b093-cf2f1e3e8f06")
                                                       Experience:
                                                       OneToThreeYears ("cc4121b2-72c2-4226-ad12-24e722b50cc2")
                                                       LessThanOneYear ("4a3e2365-47f4-45d9-b1d4-326d9f2f3203")
                                                       FiveToTenYears ("bf38a1b9-dee3-455a-87c1-4e034fe806f7")
                                                       FreshGraduate ("fbce1042-bce0-47a3-92cc-54e3b86eb570")
                                                       ThreeToFiveYears ("67db1aef-c1b1-4424-8313-774a5dccdb9d")
                                                       MoreThanTenYears ("646ccd9f-aa2f-413e-8d3e-eb8ab0b14c96")
                                                       Education:
                                                       CollegeDegree ("a3fb036a-04fc-4590-b87d-6ed32e2ec692")
                                                       MasterDegree ("bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb")
                                                       PrimarySchool ("ceb115a0-3ffe-455c-b24e-9eff074e1ec1")
                                                       Doctorate ("853384de-154c-4187-bf5d-aa684b85736d")
                                                       BachelorDegree ("bc4ecf1e-8841-47f2-86ec-b0c523f03da1")
                                                       SeniorOrVocationalHighSchool ("52e22ea6-7f97-4816-b64a-bfd4aa21cd74")
                                                       Diploma ("ebb6a034-ce37-41a4-b1f6-c70f1698c4f2")
                                                       SecondarySchool ("c9d2f457-06bf-40ad-9a4a-d6e201888129")
                                                       Gender:
                                                       Male ("79685cdb-be26-49cc-b7f9-1fb51686f5ba")
                                                       Female ("7b5f69cb-5996-4a57-b9c6-9fee2a791bf6")
                                                       Others ("12497687-64b8-4d8e-814a-b7d1d33d3aab")
                                                       Please evaluate these attributes for each job in the given list and return recommendations based on alignment with the user profile in the format specified. And the more suggestion, the more satisfy
                           """
                }
            ]
        };

    public async Task<JobSuggestionList> GenerateJobSuggestionListAsync(SuggestibleUserModel suggestibleUser, GetJobsByPaginationParams param)
    {
       var listJob = await _jobService.GetAllJobAsync(filer: param.JobFilter, order: param.Order, pagination: param.Pagination);
       var user = await _userService.GetUserById(suggestibleUser.UserId);
       if (user == null)
       {
           throw new BadRequestException("User not found");
       }

       UserInfo userInfo = new()
       {
           Skills = user.Skills.Concat(suggestibleUser.AdditionSkills), 
           SelfDescription = user.SelfDescription, 
           Certifications = user.Certifications,
           LatestSearchKeywords = suggestibleUser.LatestSearchKeywords
       };
       return await GetJobSuggestionByUserAndJobListAsync(userInfo, listJob.Data);
    }
    private async Task<JobSuggestionList> GetJobSuggestionByUserAndJobListAsync(UserInfo userProfile,
        IEnumerable<JobModel> jobList)
    {
        var tokenCancellingToken = CancellationToken.None;
        var prompt = $"{{userProfile: {JsonConvert.SerializeObject(userProfile)}" +
                     $"\njobList: {JsonConvert.SerializeObject(jobList)}}}";
        var rawResponse =
            await _geminiClient.GenerateContentAsync(prompt, tokenCancellingToken, DEFAULTSYSTEMSUGGESTION);
        var jobSuggestionList = JsonConvert.DeserializeObject<JobSuggestionList>(rawResponse);
        if (jobSuggestionList == null) 
            throw new Exception("Can't deserialize raw response to JobSuggestionList");
        return jobSuggestionList;
    }

    private class UserInfo
    {
        public IEnumerable<string> Skills { get; set; } = new List<string>();
        public string SelfDescription { get; set; } = string.Empty;
        public IEnumerable<Certification> Certifications { get; set; } = [];
        public IEnumerable<string> LatestSearchKeywords { get; set; } = [];
    }
}