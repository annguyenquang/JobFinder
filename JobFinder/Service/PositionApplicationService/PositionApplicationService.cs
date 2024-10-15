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

        private const int DEFAULT_PAGENUMBER = 1;
        private const int DEFAULT_PAGESIZE = 10;
        private const int MAX_PAGESIZE = 30;
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
            await _positionApplicationRepo.UpdateAsync(newApplicationEntity);
            
            return _mapper.Map<CreatePositionApplicationReponseModel>(saveResult);
        }

        public async Task<ListResponseModel<PositionApplicationModel>> GetAllPositionApplicationsAsync(PositionApplicationFilter filter, Order order, Pagination pagination)
        {
            var resultPagination = Pagination.validate(pagination, DEFAULT_PAGENUMBER, DEFAULT_PAGESIZE, MAX_PAGESIZE);
            var entities = await _positionApplicationRepo.GetAllAsListModelAsync(filter, order, resultPagination);
            var models = _mapper.Map<List<PositionApplicationModel>>(entities.Data);
            return new ListResponseModel<PositionApplicationModel> { Data = models, Total = entities.Total, Pagination = resultPagination };
        }
    }
}
