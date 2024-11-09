using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.Model;
using JobFinder.Model.Utils;
using JobFinder.Model.Utils.Constants;
using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;
using JobFinder.Service.StorageService;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.Service
{
    public class CompanyService(ICompanyRepository _companyRepository, IStorageService _storageService, IMapper _mapper) : ICompanyService
    {
        private const int DEFAULT_PAGENUMBER = 1;
        private const int DEFAULT_PAGESIZE = 10;
        private const int MAX_PAGESIZE = 30;
        public async Task<CreateCompanyResponseModel> CreateCompanyAsync(CreateCompanyModel company)
        {
            if (await GetCompanyBySlugAsync(company.Slug) != null)
                throw new BadRequestException("The slug is used by other companies, try new one");
            {
                var extension = Path.GetExtension(company.LogoFile.FileName.ToLower());
                if(!FileExtension.ImageExtensions.Contains(extension))
                    throw new BadRequestException("File type is not allowed");
            }
            
            var companyEntity = _mapper.Map<Company>(company);
            Company res;
            if (string.IsNullOrEmpty(company.Slug))
            {
                var slug = GenerateSlugByCompanyName(company.Name);
                var slugIsUsedByOtherCompany = await GetCompanyBySlugAsync(slug) != null;
                if (slugIsUsedByOtherCompany)
                {
                    companyEntity.Slug = null;
                    var entity = await _companyRepository.AddAsync(companyEntity);
                    slug = GenerateSlugByCompanyNameAndId(entity.Name, entity.Id);
                    entity.Slug = slug;
                    res = await _companyRepository.UpdateAsync(entity);
                }
                else
                {  
                    companyEntity.Slug = slug;
                    res = await _companyRepository.AddAsync(companyEntity);  
                }
            }
            else
            {
                res = await _companyRepository.AddAsync(companyEntity);  
            }
            
            if (res == null) throw new Exception("An error occur while saving the data");
            var fileLink = await _storageService.UploadFile(company.LogoFile);
            res.Logo = fileLink;
            var updated = await _companyRepository.UpdateAsync(res);
            return _mapper.Map<CreateCompanyResponseModel>(updated);
        }
        public async Task<ListResponseModel<CompanyModel>> GetAllCompanyAsync(CompanyFilter filter, Order order, Pagination pagination)
        {
            var returnPagination = Pagination.validate(pagination, DEFAULT_PAGENUMBER, DEFAULT_PAGESIZE, MAX_PAGESIZE);
            var entities = await _companyRepository.GetAllAsListModelAsync(filter, order, returnPagination);
            var result = new ListResponseModel<CompanyModel>
            {
                Data = _mapper.Map<List<CompanyModel>>(entities.Data),
                Total = entities.Total,
                Pagination = pagination
            };
            return result;
        }
        public async Task<CompanyModel> GetCompanyAsync(Guid id)
        {
            var entity = await _companyRepository.GetAsync(id);
            return _mapper.Map<CompanyModel>(entity);
        }
        public async Task<UpdateCompanyReponseModel> UpdateCompanyAsync(Guid id, UpdateCompanyModel newCompanyModel)
        {
            Company currentCompany = await _companyRepository.GetAsync(id);
            if (currentCompany == null)
            {
                throw new Exception("Company not found");
            }
            //Update only changed properties
            {

                if (!string.IsNullOrEmpty(newCompanyModel.EmailContact))
                {
                    currentCompany.EmailContact = newCompanyModel.EmailContact;
                }
                if (!string.IsNullOrEmpty(newCompanyModel.PhoneContact))
                {
                    currentCompany.PhoneContact = newCompanyModel.PhoneContact;
                }
                if (!string.IsNullOrEmpty(newCompanyModel.Address))
                {
                    currentCompany.Address = newCompanyModel.Address;
                }
                if (!string.IsNullOrEmpty(newCompanyModel.Website))
                {
                    currentCompany.Website = newCompanyModel.Website;
                }
            }
            var res = await _companyRepository.UpdateAsync(currentCompany);
            return _mapper.Map<UpdateCompanyReponseModel>(res);
        }
        public async Task<ListResponseModel<JobModel>> GetCompanyJobs(Guid id, JobFilter filter, Order order, Pagination pagination)
        {
            var jobs = await _companyRepository.GetCompanyJobs(id, filter, order, pagination);
            var result = new ListResponseModel<JobModel>
            {
                Data = _mapper.Map<List<JobModel>>(jobs.Data),
                Total = jobs.Total,
                Pagination = pagination
            };
            return result;
        }
        public async Task<CompanyModel> GetCompanyBySlugAsync(string slug)
        {
            var companyModel = _mapper.Map<CompanyModel>(await _companyRepository.GetCompanyBySlug(slug));
            return companyModel;
        }

        private string GenerateSlugByCompanyName(string name)
        {
            return name.Replace(" ", "-").ToLower();     
        }

        private string GenerateSlugByCompanyNameAndId(string name, Guid id)
        {
            return $"{GenerateSlugByCompanyName(name)}-{id.ToString()}";
        }
    }
}
