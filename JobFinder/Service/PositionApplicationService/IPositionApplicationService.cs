using JobFinder.Core.Entity;
using JobFinder.Model;

namespace JobFinder.Service
{
    public interface IPositionApplicationService
    {

        Task<List<PositionApplication>> GetAllPositionApplicationsAsync();
        Task<CreatePositionApplicationReponseModel> CreatePositionApplicationAsync(CreatePositionApplicationModel newApplication);

    }
}
