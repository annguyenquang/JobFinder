using JobFinder.Model;
using JobFinder.Model.Utils;
using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;

namespace JobFinder.Service
{
    public interface ICompanyService
    {
        Task<CompanyModel> GetCompanyAsync(Guid id);
        Task<ListResponseModel<CompanyModel>> GetAllCompanyAsync(CompanyFilter filter, Order order, Pagination pagination);
        Task<CreateCompanyResponseModel> CreateCompanyAsync(CreateCompanyModel company);
        Task<UpdateCompanyReponseModel> UpdateCompanyAsync(Guid id, UpdateCompanyModel companyModel);
        Task<ListResponseModel<PositionModel>> GetCompanyPositions(Guid id, PositionFilter filter, Order order, Pagination pagination);
    }
}