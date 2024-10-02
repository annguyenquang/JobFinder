using JobFinder.Model;
using JobFinder.Model.Position;

namespace JobFinder.Service
{
    public interface IPositionService
    {
        Task<PositionModel> GetPositionAsync(Guid id);
        Task<CreatePositionReponseModel> CreatePositionAsync(CreatePositionModel position);
        Task<UpdatePositionReponseModel> UpdatePositionAsync(Guid id, UpdatePositionModel positionModel);
        Task<UpdatePositionReponseModel> UpdatePositionAsync1(Guid id, UpdatePositionModel positionModel);
    }
}