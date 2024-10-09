using JobFinder.Core.Entity;
using JobFinder.Model;
using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;

namespace JobFinder.Service
{
    public interface IPositionApplicationService
    {
        Task<List<PositionApplicationModel>> GetAllPositionApplicationsAsync(PositionApplicationFilter fitler, Order order, Pagination pagination);
        Task<CreatePositionApplicationReponseModel> CreatePositionApplicationAsync(CreatePositionApplicationModel newApplication);
    }
}
