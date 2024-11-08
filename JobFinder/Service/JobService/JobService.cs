using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.Model;
using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;

namespace JobFinder.Service
{
    
    public class JobService(IJobRepository _jobRepository, IMetadataService _metadataService, IMapper _mapper) : IJobService
    {
        private const int DEFAULT_PAGENUMBER = 1;
        private const int DEFAULT_PAGESIZE = 10;
        private const int MAX_PAGESIZE = 30;
        public async Task<CreateJobReponseModel> CreateJobAsync(CreateJobModel job)
        {
            var jobEntity = await ConvertCreateJobModelToJobEntityAsync(job);
            var entity = await _jobRepository.AddAsync(jobEntity);
            return _mapper.Map<CreateJobReponseModel>(entity);
        }
        public async Task<ListResponseModel<JobModel>> GetAllJobAsync(JobFilter filter, Order order, Pagination pagination)
        {
            Pagination returnPagination = Pagination.validate(pagination, DEFAULT_PAGENUMBER, DEFAULT_PAGESIZE, MAX_PAGESIZE);
            var entities = await _jobRepository.GetAllAsListModelAsync(filter, order, returnPagination);
            var models = _mapper.Map<List<JobModel>>(entities.Data);
            return new ListResponseModel<JobModel>()
            {
                Data = models,
                Total = entities.Total,
                Pagination = returnPagination
            };
        }   
        public async Task<JobModel> GetJobAsync(Guid id)
        {
            var entity = await _jobRepository.GetAsync(id);
            return _mapper.Map<JobModel>(entity);
        }
        public async Task<UpdateJobResponseModel> UpdateJobAsync(Guid id, UpdateJobModel newJobModel)
        {
            Job newJob = _mapper.Map<Job>(newJobModel);
            var res = await _jobRepository.UpdateAsync(id, newJob);
            return _mapper.Map<UpdateJobResponseModel>(res);
        }
        private async Task<Job> ConvertCreateJobModelToJobEntityAsync(CreateJobModel model) 
        {
            var jobEntity = _mapper.Map<Job>(model);
            if (model.CommitmentTypeId.HasValue)
            {
                var commitmentType = await _metadataService.GetMetadataAsync(model.CommitmentTypeId.Value);
                jobEntity.CommitmentType = commitmentType;
            }
            if (model.WorkArrangementId.HasValue)
            {
                var workArrangement = await _metadataService.GetMetadataAsync(model.WorkArrangementId.Value);
                jobEntity.WorkArrangement = workArrangement;
            }
            if (model.WorkExperienceRequirementId.HasValue)
            {
                var workExperience = await _metadataService.GetMetadataAsync(model.WorkExperienceRequirementId.Value);
                jobEntity.WorkExperienceRequirement = workExperience;
            }
            if (model.EducationLevelRequirementId.HasValue)
            {
                var education = await _metadataService.GetMetadataAsync(model.EducationLevelRequirementId.Value);
                jobEntity.EducationLevelRequirement = education;
            }
            if (model.GenderRequirementId.HasValue)
            {
                var gender = await _metadataService.GetMetadataAsync(model.GenderRequirementId.Value);
                jobEntity.GenderRequirement = gender;
            }
            return jobEntity; 
        }
    }
}
