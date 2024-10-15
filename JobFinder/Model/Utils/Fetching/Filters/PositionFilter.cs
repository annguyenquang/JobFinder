using JobFinder.Core.Entity;

namespace JobFinder.Model.Utils.Fetching.Filters
{
    public class PositionFilter : IFilter<Position>
    {
        public double? FromSalary { get; set; }
        public double? ToSalary { get; set; }
        public PositionStatus? Status { get; set; }
        public bool? IsNotEnded { get; set; }
        public WorkArrangement? WorkArrangement { get; set; }
        public CommitmentType? CommitmentType { get; set; }
        public int? ProvinceId { get; set; }
        public int? DistrictId { get; set; }
        public int? MinAgeRequirement { get; set; }
        public int? MaxAgeRequirement { get; set; }
        public GenderRequirement? GenderRequirement { get; set; }
        public EducationLevelRequirement? EducationLevelRequirement { get; set; }
        public WorkExperienceRequirement? WorkExperienceRequirement { get; set; }
        public DateOnly? LastUpdate { get; set; }
        public IQueryable<Position> filters(IQueryable<Position> querable)
        {
            if (FromSalary.HasValue)
            {
                querable = querable.Where(x => x.Salary >= FromSalary);
            }
            if (ToSalary.HasValue)
            {
                querable = querable.Where(x => x.Salary <= ToSalary);
            }
            if (Status.HasValue)
            {
                querable = querable.Where(x => x.Status == Status);
            }
            if (IsNotEnded.HasValue && IsNotEnded.Value)
            {
                querable = querable.Where(x => x.CloseDate >= DateTime.Now);
            }
            if (WorkArrangement.HasValue)
            {
                querable = querable.Where(x => x.WorkArrangement == WorkArrangement);
            }
            if (CommitmentType.HasValue)
            {
                querable = querable.Where(x => x.CommitmentType == CommitmentType);
            }
            if (ProvinceId.HasValue)
            {
                querable = querable.Where(x => x.ProvinceId == ProvinceId);
                if (DistrictId.HasValue)
                {
                    querable = querable.Where(x => x.DistrictId == DistrictId);
                }
            }
            if (WorkExperienceRequirement.HasValue)
            {
                querable = querable.Where(x => x.WorkExperienceRequirement == WorkExperienceRequirement);
            }
            if (EducationLevelRequirement.HasValue)
            {
                querable = querable.Where(x => x.EducationLevelRequirement == EducationLevelRequirement);
            }
            if(LastUpdate.HasValue)
            {
                querable = querable.Where(x => x.UpdatedAt >= (DateTime.Now - LastUpdate.Mafasdfasdf));
            }
            //
            if (MinAgeRequirement.HasValue)
            {
                querable = querable.Where(x => x.MinAgeRequirement >= MinAgeRequirement);
            }
            if (MaxAgeRequirement.HasValue)
            {
                querable = querable.Where(x => x.MaxAgeRequirement <= MaxAgeRequirement);
            }
            if (GenderRequirement.HasValue)
            {
                querable = querable.Where(x => x.GenderRequirement == GenderRequirement);
            }
            return querable;
        }
    }
}
