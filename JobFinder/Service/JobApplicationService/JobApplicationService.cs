﻿using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.Model;
using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils;
using JobFinder.Service.StorageService;
using JobFinder.Model.Utils.Fetching.Filters;

namespace JobFinder.Service
{
    public class JobApplicationService(IJobApplicationRepository _jobApplicationRepo, IStorageService _storageService, IMapper _mapper) : IJobApplicationService
    {

        private const int DEFAULT_PAGENUMBER = 1;
        private const int DEFAULT_PAGESIZE = 10;
        private const int MAX_PAGESIZE = 30;
        public async Task<CreateJobApplicationReponseModel> CreateJobApplicationAsync(CreateJobApplicationModel newApplication)
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

            string fileLink = await _storageService.UploadFile(newApplication.CVFile);
            newApplicationEntity.CVLink = fileLink;
            await _jobApplicationRepo.UpdateAsync(newApplicationEntity);
            
            return _mapper.Map<CreateJobApplicationReponseModel>(saveResult);
        }

        public async Task<ListResponseModel<JobApplicationModel>> GetAllJobApplicationsAsync(JobApplicationFilter filter, Order order, Pagination pagination)
        {
            var resultPagination = Pagination.validate(pagination, DEFAULT_PAGENUMBER, DEFAULT_PAGESIZE, MAX_PAGESIZE);
            var entities = await _jobApplicationRepo.GetAllAsListModelAsync(filter, order, resultPagination);
            var models = _mapper.Map<List<JobApplicationModel>>(entities.Data);
            return new ListResponseModel<JobApplicationModel> { Data = models, Total = entities.Total, Pagination = resultPagination };
        }
    }
}