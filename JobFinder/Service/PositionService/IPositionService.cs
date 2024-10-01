using JobFinder.Model;

namespace JobFinder.Service
{
    public interface IPositionService
    {
        Task<PositionModel> GetPosition(Guid id);
    }
}