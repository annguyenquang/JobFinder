﻿using JobFinder.Core.Entity;

namespace JobFinder.Model
{
    public class FirmModel : BaseResponseModel
    {
        public string EmailContact { get; set; } = string.Empty;
        public string PhoneContact { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Website { get; set; } = string.Empty;
    }
}
