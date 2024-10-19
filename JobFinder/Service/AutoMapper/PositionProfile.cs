using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Model;

namespace JobFinder.Service.AutoMapper
{
    public class PositionProfile : Profile
    {
        public PositionProfile()
        {
            CreateMap<Position, PositionModel>();
            CreateMap<CreatePositionModel, Position>()
                .ForPath(des => des.CommitmentType.Id, opt => opt.MapFrom(x => x.CommitmentTypeId))
                .ForPath(des => des.WorkArrangement.Id, opt => opt.MapFrom(x => x.WorkArrangementId))
                .ForPath(des => des.WorkExperienceRequirement.Id, opt => opt.MapFrom(x => x.WorkExperienceRequirementId))
                .ForPath(des => des.EducationLevelRequirement.Id, opt => opt.MapFrom(x => x.EducationLevelRequirementId))
                .ForPath(des => des.GenderRequirement.Id, opt => opt.MapFrom(x => x.GenderRequirementId));
            CreateMap<Position, CreatePositionReponseModel>();
            CreateMap<UpdatePositionModel, Position>();
            CreateMap<Position, UpdatePositionReponseModel>();
            CreateMap<Metadata?, MetadataModel?>();
        }
    }
}
