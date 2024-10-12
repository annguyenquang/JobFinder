using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.Model;
using JobFinder.Model.Utils;
using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;

namespace JobFinder.Service
{
    public class CompanyService(ICompanyRepository _companyRepository, IMapper _mapper) : ICompanyService
    {
        public async Task<CreateCompanyResponseModel> CreateCompanyAsync(CreateCompanyModel company)
        {
            var companyEntity = _mapper.Map<Company>(company);
            var entity = await _companyRepository.AddAsync(companyEntity);
            return _mapper.Map<CreateCompanyResponseModel>(entity);
        }
        public async Task<List<CompanyModel>> GetAllCompanyAsync(CompanyFilter filter, Order order, Pagination pagination)
        {

            var entities = await _companyRepository.GetAllAsync(filter, order, pagination);
            return _mapper.Map<List<CompanyModel>>(entities);
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
        public async Task<List<PositionModel>> GetCompanyPositions(Guid id, PositionFilter filter, Order order, Pagination pagination)
        {
            var positions = await _companyRepository.GetCompanyPositions(id, filter, order, pagination);
            return _mapper.Map<List<PositionModel>>(positions);
        }
    }
}
