using JobFinder.Model;
using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;

namespace JobFinder.Service
{
    public interface IPositionService
    {
        Task<PositionModel> GetPositionAsync(Guid id);
        Task<ListResponseModel<PositionModel>> GetAllPositionAsync(PositionFilter filer, Order order, Pagination pagination);
        Task<CreatePositionReponseModel> CreatePositionAsync(CreatePositionModel position);
        Task<UpdatePositionReponseModel> UpdatePositionAsync(Guid id, UpdatePositionModel positionModel);
    }
}