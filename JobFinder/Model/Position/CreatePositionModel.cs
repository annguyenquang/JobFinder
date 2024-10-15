﻿using JobFinder.Core.Entity;

namespace JobFinder.Model
{
    public class CreatePositionModel
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double? Salary { get; set; }
        public PositionStatus? Status { get; set; } = PositionStatus.Open;
        public DateTime? CloseDate { get; set; }
        public WorkArrangement? WorkArrangement { get; set; }
        public CommitmentType? CommitmentType { get; set; }
        /// Location 
        public int? ProvinceId { get; set; }
        public int? DistrictId { get; set; }
        /// Requirements
        public int? MinAgeRequirement { get; set; }
        public int? MaxAgeRequirement { get; set; }
        public GenderRequirement? GenderRequirement { get; set; }
        public EducationLevelRequirement? EducationLevelRequirement { get; set; }
        public WorkExperienceRequirement? WorkExperienceRequirement { get; set; }
        public Guid CompanyId { get; set; }
    }
    public class CreatePositionReponseModel : BaseResponseModel { }
}
