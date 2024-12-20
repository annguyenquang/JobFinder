using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.DataAccess.Persistent;
using JobFinder.Model;
using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.DataAccess.Repository
{
    public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(DatabaseContext _dbContext) : base(_dbContext)
        {
        }
        public async Task<Company> GetCompanyBySlug(string slug)
        {
            var company = await DbSet.FirstOrDefaultAsync(x => x.Slug == slug);
            return company;
        }

        public async Task<ListModel<Job>> GetCompanyJobs(Guid companyId, JobFilter filter, Order order,
            Pagination pagination)
        {
            IQueryable<Company> queryableCompany = DbSet
                .Include(x => x.Jobs)
                    .ThenInclude(x => x.WorkArrangement)
                .Include(x => x.Jobs)
                    .ThenInclude(x => x.CommitmentType)
                .Include(x => x.Jobs)
                    .ThenInclude(x => x.GenderRequirement)
                .Include(x => x.Jobs)   
                    .ThenInclude(x => x.EducationLevelRequirement)
                .Include(x => x.Jobs)   
                    .ThenInclude(x => x.WorkExperienceRequirement)
                .AsSplitQuery();
            queryableCompany = queryableCompany.Where(x => x.Id == companyId);

            var queryableJob = queryableCompany.SelectMany(x => x.Jobs);

            if (filter != null)
            {
                queryableJob = filter.filters(queryableJob);
            }

            if (order != null)
            {
                queryableJob = Order.ApplyOrdering(queryableJob, order.By, order.IsDesc);
            }
            else
            {
                queryableJob = queryableJob.OrderBy(x => x.CreatedAt);
            }

            int total = await queryableJob.CountAsync();
            if (pagination != null)
            {
                int skip = pagination.PageSize * (pagination.Page - 1);
                int take = pagination.PageSize;
                queryableJob = queryableJob.Skip(skip).Take(take);
            }

            var result = new ListModel<Job>
            {
                Data = await queryableJob.ToListAsync(),
                Total = total,
            };

            return result;
        }
    }
}