using JobFinder.Model;
using JobFinder.Model.Utils;
using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;

namespace JobFinder.Service
{
    public interface IFirmService
    {
        Task<FirmModel> GetFirmAsync(Guid id);
        Task<List<FirmModel>> GetAllFirmAsync(FirmFilter filter, Order order, Pagination pagination);
        Task<CreateFirmResponseModel> CreateFirmAsync(CreateFirmModel firm);
        Task<UpdateFirmReponseModel> UpdateFirmAsync(Guid id, UpdateFirmModel firmModel);
    }
}