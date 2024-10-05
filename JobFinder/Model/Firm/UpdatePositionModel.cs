using JobFinder.Core.Entity;

namespace JobFinder.Model
{
    public class UpdateFirmModel
    {
        public string? EmailContact { get; set; }
        public string? PhoneContact { get; set; }
        public string? Address { get; set; }
        public string? Website { get; set; }
    }
    public class UpdateFirmReponseModel : BaseResponseModel { }
}
