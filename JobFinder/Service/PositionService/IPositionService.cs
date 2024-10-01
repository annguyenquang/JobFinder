using JobFinder.Model;

namespace JobFinder.Service
{
    public interface IPositionService
    {
        Task<PositionModel> GetPositionAsync(Guid id);
        Task<CreatePositionReponseModel> CreatePositionAsync(CreatePositionModel position);
    }
}