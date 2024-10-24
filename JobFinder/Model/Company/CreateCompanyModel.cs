﻿using JobFinder.Core.Entity;

namespace JobFinder.Model
{
    public class CreateCompanyModel
    {
        public Guid AccountId { get; set; }
        public string EmailContact { get; set; } = string.Empty;
        public string PhoneContact { get; set; } = string.Empty;
        public string? Address { get; set; } = string.Empty;
        public string? Website { get; set; } = string.Empty;
        public string? Industry { get; set; } = string.Empty;    
        public int? EmployeeCount { get; set; } 

    }
    public class CreateCompanyResponseModel : BaseResponseModel { }
}
