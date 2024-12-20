using System.Diagnostics;
using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.DataAccess.Persistent;
using JobFinder.Model;
using JobFinder.Model.Exceptions;
using JobFinder.Model.Utils;
using JobFinder.Model.Utils.Fetching;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace JobFinder.DataAccess.Repository
{
    public class JobRepository : BaseRepository<Job>, IJobRepository
    {
        public JobRepository(DatabaseContext _dbContext) : base(_dbContext)
        {
        }
        public new async Task<Job> GetAsync(Guid id)
        {
            var result = await DbSet
                .Include(x => x.Company)
                .Include(x => x.WorkArrangement) 
                .Include(x => x.CommitmentType) 
                .Include(x => x.WorkExperienceRequirement) 
                .Include(x => x.EducationLevelRequirement)
                .Include(x => x.GenderRequirement) 
                .AsSplitQuery()
                .SingleAsync(x => x.Id == id);
            if (result == null) throw new NotFoundException($"Resouce of type {typeof(Job)} is not founded");
            return result;

        }
        
        public new async Task<ListModel<Job>> GetAllAsListModelAsync(IFilter<Job> filter, Order order, Pagination pagination)
        {
            var queryable = DbSet
                .Include(x => x.Company)
                .Include(x => x.WorkArrangement)
                .Include(x => x.CommitmentType)
                .Include(x => x.WorkExperienceRequirement)
                .Include(x => x.EducationLevelRequirement)
                .Include(x => x.GenderRequirement)
                .Include(x => x.JobApplications)
                .AsNoTracking()
                .AsSplitQuery();
            if (filter != null)
            {
                queryable = filter.filters(queryable);
            }
            
            if(order != null)
            {
                queryable = Order.ApplyOrdering(queryable, order.By, order.IsDesc);                
            }
            else
            {
                queryable = queryable.OrderByDescending(x => x.UpdatedAt);
            }
            
            int total = await queryable.CountAsync();
            
            if (pagination != null)
            {
                int skip = pagination.PageSize * (pagination.Page - 1);
                int take = pagination.PageSize;
                queryable = queryable.Skip(skip).Take(take);
            }
            var entityList = await queryable.ToListAsync();
            return new ListModel<Job>() { Data = entityList, Total = total };

        }

        public async Task<Job> UpdateAsync(Guid id, Job newJob)
        {
            var currentJob = await GetAsync(id);
            if (currentJob == null)
            {
                throw new Exception("The id does not match any");
            }
            List<PropertyInfo> properties = [.. typeof(Job).GetProperties()];
            // Filter out the unchangeable properties
            properties = properties.Where(p =>
                    p.Name != nameof(Job.Id)
                    && p.Name != nameof(Job.CompanyId)
                    && p.Name != nameof(Job.Company)
                    ).ToList();
            foreach (PropertyInfo property in properties)
            {
                var newValue = property.GetValue(newJob);
                var currentValue = property.GetValue(currentJob);
                if (property.Name == nameof(Job.Title))
                {
                }
                if (newValue != null && newValue != currentValue)
                {
                    property.SetValue(currentJob, newValue);
                }
            }
            int result = await Context.SaveChangesAsync();
            return currentJob;
        }
    }
}
