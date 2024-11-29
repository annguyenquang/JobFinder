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
        public async Task<ApiResult<ListResponseModel<CompanyModel>>> GetCompanysByPagination([FromQuery] GetCompaniesByPaginationParams param)
        {
            var companies = await _companyService.GetAllCompanyAsync(param.Filter, param.Order, param.Pagination);
            return ApiResult<ListResponseModel<CompanyModel>>.Success(companies);
        }
        [HttpGet("{slug}")]
        public async Task<ApiResult<CompanyModel>> GetCompanyBySlug(string slug)
        {
            var company = await _companyService.GetCompanyBySlugAsync(slug);
            return ApiResult<CompanyModel>.Success(company);
        }
        [HttpGet("{id}/jobs")]
        public async Task<ApiResult<ListResponseModel<JobModel>>> GetCompanyJobs(Guid id, [FromQuery] GetCompanyJobsParams param)
        {
            var jobs = await _companyService.GetCompanyJobs(id, param.Filter, param.Order, param.Pagination);
            return ApiResult<ListResponseModel<JobModel>>.Success(jobs);
        } 
        [HttpPost]
        public async Task<ApiResult<CreateCompanyResponseModel>> CreateCompany([FromForm] CreateCompanyModel Company)
        {
            var response = await _companyService.CreateCompanyAsync(Company);
            return ApiResult<CreateCompanyResponseModel>.Success(response);
        }
        [HttpPatch("{id}")]
        public async Task<ApiResult<UpdateCompanyResponseModel>> UpdateCompany(Guid id, [FromForm] UpdateCompanyModel newCompanyModel)
        {
            var response = await _companyService.UpdateCompanyAsync(id, newCompanyModel);
            return ApiResult<UpdateCompanyResponseModel>.Success(response);
        }
    }
}
