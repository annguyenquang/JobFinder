using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.Model;
using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils;
using JobFinder.Service.StorageService;
using JobFinder.Model.Utils.Fetching.Filters;

namespace JobFinder.Service
{
    public class PositionApplicationService(IPositionApplicationRepository _positionApplicationRepo, IStorageService _storageService, IMapper _mapper) : IPositionApplicationService
    {
        public async Task<CreatePositionApplicationReponseModel> CreatePositionApplicationAsync(CreatePositionApplicationModel newApplication)
        {
            if(Path.GetExtension(newApplication.CVFile.FileName.ToLower()) != ".pdf")
            {
                throw new BadRequestException("File type is not allowed");
            }

            var newApplicationEntity = _mapper.Map<PositionApplication>(newApplication);
            var saveResult = await _positionApplicationRepo.AddAsync(newApplicationEntity);
            if (saveResult == null)
            {
                throw new Exception("An error occur while saving the data");
            }

            string fileLink = await _storageService.UploadFile(newApplication.CVFile);
            newApplicationEntity.CVLink = fileLink;
            _positionApplicationRepo.UpdateAsync(newApplicationEntity);
            
            return _mapper.Map<CreatePositionApplicationReponseModel>(saveResult);
        }

        public async Task<List<PositionApplicationModel>> GetAllPositionApplicationsAsync(PositionApplicationFilter filter, Order order, Pagination pagination)
        {
            var listEntity = await _positionApplicationRepo.GetAllAsync(filter, order,pagination);
            return _mapper.Map<List<PositionApplicationModel>>(listEntity);
        }
    }
}
