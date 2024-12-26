using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.Model;
using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Constants;
using JobFinder.Model.Utils.Fetching.Filters;
using JobFinder.Service.StorageService;

namespace JobFinder.Service
{
    public class JobApplicationService(IJobApplicationRepository _jobApplicationRepo, IStorageService _storageService, IUserService _userService, IMapper _mapper) : IJobApplicationService
    {

        private const int DEFAULT_PAGENUMBER = 1;
        private const int DEFAULT_PAGESIZE = 10;
        private const int MAX_PAGESIZE = 30;
        public async Task<ListResponseModel<UserApplication>> GetApplicationsByUserId(Guid userId, GetJobApplicationByUserIdParam param)
        {
            param.Filter ??= new GetJobApplicationByUserIdFilter(); 
            param.Filter.UserId = userId;
            param.Pagination = Pagination.Validate(param.Pagination, DEFAULT_PAGENUMBER, DEFAULT_PAGESIZE);

            var entities =
                await _jobApplicationRepo.GetAllAsListModelAsync(param.Filter, param.Order, param.Pagination);
            var models = _mapper.Map<List<UserApplication>>(entities.Data);
            return new ListResponseModel<UserApplication>{ Data = models, Total = entities.Total, Pagination = param.Pagination };
        }

        public async Task<CreateJobApplicationResponseModel> CreateJobApplicationAsync(CreateJobApplicationModel newApplication)
        {
            if(Path.GetExtension(newApplication.CVFile.FileName.ToLower()) != ".pdf")
            {
                throw new BadRequestException("File type is not allowed");
            }

            var newApplicationEntity = _mapper.Map<JobApplication>(newApplication);
            var saveResult = await _jobApplicationRepo.AddAsync(newApplicationEntity);
            if (saveResult == null)
            {
                throw new Exception("An error occur while saving the data");
            }

            var submitter = await _userService.GetUserById(saveResult.UserId.Value);
            var fileLink = await _storageService.UploadFile(newApplication.CVFile, 
                AzureContainer.DocumentsContainer, 
                GenerateFileName(submitter.FirstName, submitter.LastName));
            newApplicationEntity.CVLink = fileLink;
            await _jobApplicationRepo.UpdateAsync(newApplicationEntity);
            
            return _mapper.Map<CreateJobApplicationResponseModel>(saveResult);
        }

        public async Task<Guid> UpdateJobApplicationAsync(Guid id, UpdateJobApplicationModel jobApplication)
        {
            var entity = await _jobApplicationRepo.GetAsync(id);
            if (entity == null) throw new ResourceNotFoundException("Job Application Not Found");

            if (!string.IsNullOrEmpty(jobApplication.CoverLetter))
            {
                entity.CoverLetter = jobApplication.CoverLetter;
            }
            if (jobApplication.PhoneNumber != null)
            {
                entity.PhoneNumber = jobApplication.PhoneNumber;
            }
            if (jobApplication.State.HasValue)
            {
                entity.State = jobApplication.State.Value;
            }
            var updateResult = await _jobApplicationRepo.UpdateAsync(entity);
            return updateResult.Id;
        }

        private static string GenerateFileName(string firstName, string lastName)
        {
            return $"{firstName}{lastName}_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}";
        }
        public async Task<ListResponseModel<JobApplicationModel>> GetAllJobApplicationsAsync(JobApplicationFilter filter, Order order, Pagination pagination)
        {
            pagination = Pagination.Validate(pagination, DEFAULT_PAGENUMBER, DEFAULT_PAGESIZE, MAX_PAGESIZE);
            var entities = await _jobApplicationRepo.GetAllAsListModelAsync(filter, order, pagination);
            var models = _mapper.Map<List<JobApplicationModel>>(entities.Data);
            return new ListResponseModel<JobApplicationModel> { Data = models, Total = entities.Total, Pagination = pagination };
        }
    }
}
