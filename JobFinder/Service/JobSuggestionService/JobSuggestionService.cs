using JobFinder.Model;
using JobFinder.Service.GeminiService;
using Newtonsoft.Json;

namespace JobFinder.Service;

public interface IJobSuggestionService
{
    public Task<JobSuggestionWithExplanation> GetJobSuggestionWithExplanation(SuggestibleUserModel userProfile,
        IEnumerable<JobModel> jobList);
}

public sealed class JobSuggestionService(IGeminiClient _geminiClient) : IJobSuggestionService
{
    public GeminiContent DEFAULTSYSTEMSUGGESTION =
        new()
        {
            Role = "user",
            Parts =
            [
                new GeminiPart()
                {
                    Text =
                        "Develop an AI model to suggest suitable job opportunities for users based on multiple attributes within a given job list. Each job entry includes key fields such as CommitmentType, WorkArrangement, Experience, Education, and Gender. The AI model should evaluate a user’s profile, recent search history, and preferences to return the most relevant job suggestions. Each job recommendation should be tailored based on the user'\''s preferences and profile information and should respect the values provided below.\n\nReturn the recommendations in the following structure:\n{\n  explanation: \"Explanation of the factors used to choose the jobs\", \n  suggestion: [\n    { \n      jobId: \"string\", \n      detailed_reason: \"Detailed reason for choosing this job\"\n    },\n    // additional jobs if applicable\n  ]\n}\nUse these mappings for matching job requirements:\n\nCommitmentType:\nContract (ID: \"44b668b2-09ee-499e-af95-73598f9153a2\")\nInternship (\"3fbef738-ed16-4778-8463-8390444841de\")\nFullTime (\"540f318e-b42f-4485-9e60-8faa5bf80962\")\nDaily (\"96279c48-1bfe-441d-992e-db86cb3bf315\")\nFreelance (\"26a49bd7-ad8c-40be-8e7c-dd903f7a653e\")\nPartTime (\"5d06c3b1-2bd1-4c68-96b4-f4cd8c899dff\")\nWorkArrangement:\nOnsite (\"04a9de34-0869-41b2-87a8-63c20c4ba22a\")\nRemote/WFH (\"376764fa-28ec-4a08-80e3-a6ab407e8601\")\nHybrid (\"c199da74-c2fb-4381-b093-cf2f1e3e8f06\")\nExperience:\nOneToThreeYears (\"cc4121b2-72c2-4226-ad12-24e722b50cc2\")\nLessThanOneYear (\"4a3e2365-47f4-45d9-b1d4-326d9f2f3203\")\nFiveToTenYears (\"bf38a1b9-dee3-455a-87c1-4e034fe806f7\")\nFreshGraduate (\"fbce1042-bce0-47a3-92cc-54e3b86eb570\")\nThreeToFiveYears (\"67db1aef-c1b1-4424-8313-774a5dccdb9d\")\nMoreThanTenYears (\"646ccd9f-aa2f-413e-8d3e-eb8ab0b14c96\")\nEducation:\nCollegeDegree (\"a3fb036a-04fc-4590-b87d-6ed32e2ec692\")\nMasterDegree (\"bc44b9a9-5cd6-4195-a7bd-92b4bef6d8fb\")\nPrimarySchool (\"ceb115a0-3ffe-455c-b24e-9eff074e1ec1\")\nDoctorate (\"853384de-154c-4187-bf5d-aa684b85736d\")\nBachelorDegree (\"bc4ecf1e-8841-47f2-86ec-b0c523f03da1\")\nSeniorOrVocationalHighSchool (\"52e22ea6-7f97-4816-b64a-bfd4aa21cd74\")\nDiploma (\"ebb6a034-ce37-41a4-b1f6-c70f1698c4f2\")\nSecondarySchool (\"c9d2f457-06bf-40ad-9a4a-d6e201888129\")\nGender:\nMale (\"79685cdb-be26-49cc-b7f9-1fb51686f5ba\")\nFemale (\"7b5f69cb-5996-4a57-b9c6-9fee2a791bf6\")\nOthers (\"12497687-64b8-4d8e-814a-b7d1d33d3aab\")\nPlease evaluate these attributes for each job in the given list and return recommendations based on alignment with the user profile in the format specified. And the more suggestion, the more satisfy\n"
                }
            ]
        };

    public async Task<JobSuggestionWithExplanation> GetJobSuggestionWithExplanation(SuggestibleUserModel userProfile,
        IEnumerable<JobModel> jobList)
    {
        var tokenCancellingToken = new CancellationTokenSource();
        string prompt = "userProfile:" + JsonConvert.SerializeObject(userProfile)
                                       + "\njobList:" + JsonConvert.SerializeObject(jobList);
        string rawResponse =
            await _geminiClient.GenerateContentAsync(prompt, CancellationToken.None, DEFAULTSYSTEMSUGGESTION);
        return null;
    }
}

public record JobSuggestionWithExplanation
{
    public string Explanation { get; init; } = string.Empty;

    public IEnumerable<JobSuggestionWithExplanation> Suggestions { get; init; } =
        new List<JobSuggestionWithExplanation>();
}

public record JobSuggestion
{
    public Guid JobId { get; init; }
    public string DetailExplanation { get; init; } = string.Empty;
}