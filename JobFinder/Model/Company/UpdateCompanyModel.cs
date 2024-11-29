using JobFinder.Core.Entity;

namespace JobFinder.Model
{
    public class UpdateCompanyModel
    {
        public string Name { get; set; } = string.Empty;
        public string? EmailContact { get; set; }
        public string? PhoneContact { get; set; }
        public string? Address { get; set; }
        public string? Website { get; set; }
        public string Slug { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public IFormFile? LogoFile { get; set; }
        public int? EmployeeCount { get; set; }

        public int ProvinceId { get; set; }

        public int DistrictId { get; set; }
    }

    public class UpdateCompanyResponseModel : IBaseResponseModel
    {
        public Guid Id { get; set; }
    }
}