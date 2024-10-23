using JobFinder.Core.Entity;
using JobFinder.Model;
using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;

namespace JobFinder.Core.Repository
{
    public interface ICompanyRepository : IBaseRepository<Company>
    {
        Task<ListModel<Position>> GetCompanyPositions(Guid companyId, PositionFilter filter, Order order, Pagination pagination);
        Task<Company> GetCompanyBySlug(string slug);
    }
}
