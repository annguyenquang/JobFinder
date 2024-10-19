
namespace JobFinder.Model
{
    public class CompanyModel : BaseResponseModel
    {
        public string Name { get; set; } = string.Empty;
        public string EmailContact { get; set; } = string.Empty;
        public string PhoneContact { get; set; } = string.Empty;
        public int? EmployeeCount { get; set; } 
        public string Slug { get;set; } = string.Empty;
        public string? Address { get; set; } = string.Empty;
        public string? Website { get; set; } = string.Empty;
        public string? Industry { get; set; } = string.Empty;
        public string Nation { get; set; } = string.Empty;
    }
}
