
using JobFinder.Model;
using JobFinder.Service;
using Microsoft.AspNetCore.Mvc;

namespace JobFinder.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompanyController(ICompanyService _companyService) : ControllerBase
    {
        [HttpGet]
        public async Task<ApiResult<CompanyModel>> GetCompany(Guid id)
        {
            var account = await _companyService.GetCompanyAsync(id);
            return ApiResult<CompanyModel>.Success(account);
        }
        [HttpGet]
        public async Task<ApiResult<IEnumerable<CompanyModel>>> GetCompanysByPagination([FromQuery] GetCompaniesByPaginationParams param)
        {
            var companies = await _companyService.GetAllCompanyAsync(param.Filter, param.Order, param.Pagination);
            return ApiResult<IEnumerable<CompanyModel>>.Success(companies);
        } 
        [HttpGet("{id}/positions")]
        public async Task<ApiResult<IEnumerable<PositionModel>>> GetCompanyPositions(Guid id, [FromQuery] GetCompanyPositionsParams param)
        {
            var positions = await _companyService.GetCompanyPositions(id, param.Filter, param.Order, param.Pagination);
            return ApiResult<IEnumerable<PositionModel>>.Success(positions);
        } 
        [HttpPost]
        public async Task<ApiResult<CreateCompanyResponseModel>> CreateCompany(CreateCompanyModel Company)
        {
            var response = await _companyService.CreateCompanyAsync(Company);
            return ApiResult<CreateCompanyResponseModel>.Success(response);
        }
        [HttpPatch("{id}")]
        public async Task<ApiResult<UpdateCompanyReponseModel>> UpdateCompany(Guid id, [FromBody] UpdateCompanyModel newCompanyModel)
        {
            var response = await _companyService.UpdateCompanyAsync(id, newCompanyModel);
            return ApiResult<UpdateCompanyReponseModel>.Success(response);
        }
    }
}
