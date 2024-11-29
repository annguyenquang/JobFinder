using JobFinder.Core.Entity;

namespace JobFinder.Model
{
    public class UpdateCompanyModel
    {
        public string? EmailContact { get; set; }
        public string? PhoneContact { get; set; }
        public string? Address { get; set; }
        public string? Website { get; set; }
    }
    public class UpdateCompanyResponseModel : IBaseResponseModel
    {
        public Guid Id { get; set; }
    }
}
