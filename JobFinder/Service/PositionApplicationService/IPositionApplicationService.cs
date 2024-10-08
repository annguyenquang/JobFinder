using JobFinder.Core.Entity;

namespace JobFinder.Service
{
    public interface IPositionApplicationService
    {

        Task<List<PositionApplication>> GetAllPositionApplicationsAsync();
    }
}
