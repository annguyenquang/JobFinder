using System.Diagnostics;
using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.DataAccess.Persistent;
using JobFinder.Model;
using JobFinder.Model.Utils;
using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace JobFinder.Service
{
    public class JobService(
        IDbContextFactory<DatabaseContext> dbContextFactory,
        IMetadataService _metadataService,
        IMapper mapper) : IJobService, IGetAllEntities<Job>
    {
        private const int DEFAULT_PAGENUMBER = 1;
        private const int DEFAULT_PAGESIZE = 10;
        private const int MAX_PAGESIZE = 30;

        public async Task<CreateJobReponseModel> CreateJobAsync(CreateJobModel job)
        {
            await using var dbContext = await dbContextFactory.CreateDbContextAsync();
            var jobEntity = await ConvertCreateJobModelToJobEntityAsync(job);
            var entity = await dbContext.AddAsync(jobEntity);
            return mapper.Map<CreateJobReponseModel>(entity);
        }

        public async Task<ListResponseModel<JobModel>> GetAllJobAsync(JobFilter filter, Order order,
            Pagination pagination)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            await using var dbContext = await dbContextFactory.CreateDbContextAsync();
            if (pagination != null)
            {
                if (pagination.PageSize == -1)
                {
                    pagination.PageSize = 100;
                }
                else
                {
                    pagination = Pagination.Validate(pagination, DEFAULT_PAGENUMBER, DEFAULT_PAGESIZE, MAX_PAGESIZE);
                }
            }

            var entities = await GetAllEntities(filter, order, pagination);
            var models = mapper.Map<List<JobModel>>(entities.Data);
            Console.WriteLine("Execute time: " + sw.ElapsedMilliseconds);
            sw.Stop();
            return new ListResponseModel<JobModel>()
            {
                Data = models,
                Total = entities.Total,
                Pagination = pagination
            };
        }

        public async Task<JobModel> GetJobAsync(Guid id)
        {
            await using var dbContext = await dbContextFactory.CreateDbContextAsync();
            var entity = await dbContext.Jobs.FindAsync(id);
            return mapper.Map<JobModel>(entity);
        }

        public async Task<UpdateJobResponseModel> UpdateJobAsync(Guid id, UpdateJobModel newJobModel)
        {
            await using var dbContext = await dbContextFactory.CreateDbContextAsync();
            Job newJob = mapper.Map<Job>(newJobModel);
            var res = await dbContext.Jobs
                .Where(x => x.Id == id)
                .ExecuteUpdateAsync(setter =>
                    setter.SetProperty(x => x.Title, x => newJob.Title ?? x.Title)
                        .SetProperty(x => x.Description, x => newJob.Description ?? x.Description)
                        .SetProperty(x => x.Salary, x => newJob.Salary ?? x.Salary)
                        .SetProperty(x => x.WorkExperienceRequirementId,
                            x => newJob.WorkExperienceRequirementId ?? x.WorkExperienceRequirementId)
                        .SetProperty(x => x.EducationLevelRequirementId,
                            x => newJob.EducationLevelRequirementId ?? x.EducationLevelRequirementId)
                        .SetProperty(x => x.CommitmentTypeId, x => newJob.CommitmentTypeId ?? x.CommitmentTypeId)
                        .SetProperty(x => x.WorkArrangementId, x => newJob.WorkArrangementId ?? x.WorkArrangementId)
                        .SetProperty(x => x.MaxAgeRequirement, x => newJob.MaxAgeRequirement ?? x.MaxAgeRequirement)
                        .SetProperty(x => x.MinAgeRequirement, x => newJob.MinAgeRequirement ?? x.MinAgeRequirement)
                        .SetProperty(x => x.Status, x => newJob.Status)
                        .SetProperty(x => x.Skills, x => newJob.Skills ?? x.Skills));
            return mapper.Map<UpdateJobResponseModel>(res);
        }

        private async Task<Job> ConvertCreateJobModelToJobEntityAsync(CreateJobModel model)
        {
            var jobEntity = mapper.Map<Job>(model);
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

        public async Task<ListModel<Job>> GetAllEntities(IFilter<Job> filter, Order order, Pagination pagination)
        {
            Task<int> getCountTask;
            Task<List<Job>> fetchJobTask;

            await using (var countContext = await dbContextFactory.CreateDbContextAsync())
            await using (var fetchContext = await dbContextFactory.CreateDbContextAsync())
            {
                getCountTask = filter != null
                    ? filter.filters(countContext.Jobs).CountAsync()
                    : countContext.Jobs.CountAsync();
                var fetchQuery = fetchContext
                    .Jobs
                    .AsNoTracking() 
                    .Include(x => x.CommitmentType)
                    .Include(x => x.WorkExperienceRequirement)
                    .Include(x => x.EducationLevelRequirement)
                    .Include(x => x.GenderRequirement)
                    .Include(x => x.WorkArrangement)
                    .Include(x => x.Company)
                    .AsSplitQuery();
                if (filter != null)
                {
                    fetchQuery = filter.filters(fetchQuery);
                }

                if (order != null)
                {
                    fetchQuery = Order.ApplyOrdering(fetchQuery, order.By, order.IsDesc);
                }

                if (pagination != null)
                {
                    fetchQuery = fetchQuery.Skip(pagination.PageSize * (pagination.Page - 1))
                        .Take(pagination.PageSize);
                }

                fetchJobTask = fetchQuery.ToListAsync();
                await Task.WhenAll(getCountTask, fetchJobTask);
            }

            return new ListResponseModel<Job>
            {
                Data = fetchJobTask.Result,
                Total = getCountTask.Result,
                Pagination = pagination
            };
        }
    }
}