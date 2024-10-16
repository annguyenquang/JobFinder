using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.Model;
using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;

namespace JobFinder.Service
{
    
    public class PositionService(IPositionRepository _positionRepository, IMapper _mapper) : IPositionService
    {
        private const int DEFAULT_PAGENUMBER = 1;
        private const int DEFAULT_PAGESIZE = 10;
        private const int MAX_PAGESIZE = 30;
        public async Task<CreatePositionReponseModel> CreatePositionAsync(CreatePositionModel position)
        {
            var positionEntity = _mapper.Map<Position>(position);
            var entity = await _positionRepository.AddAsync(positionEntity);
            return _mapper.Map<CreatePositionReponseModel>(entity);
        }

        public async Task<ListResponseModel<PositionModel>> GetAllPositionAsync(PositionFilter filter, Order order, Pagination pagination)
        {
            Pagination returnPagination = Pagination.validate(pagination, DEFAULT_PAGENUMBER, DEFAULT_PAGESIZE, MAX_PAGESIZE);
            var entities = await _positionRepository.GetAllAsListModelAsync(filter, order, returnPagination);
            var models = _mapper.Map<List<PositionModel>>(entities.Data);
            return new ListResponseModel<PositionModel>()
            {
                Data = models,
                Total = entities.Total,
                Pagination = returnPagination
            };
        }   
        public async Task<PositionModel> GetPositionAsync(Guid id)
        {
            var entity = await _positionRepository.GetAsync(id);
            return _mapper.Map<PositionModel>(entity);
        }
        public async Task<UpdatePositionReponseModel> UpdatePositionAsync(Guid id, UpdatePositionModel newPositionModel)
        {
            Position newPosition = _mapper.Map<Position>(newPositionModel);
            var res = await _positionRepository.UpdateAsync(id, newPosition);
            return _mapper.Map<UpdatePositionReponseModel>(res);
        }

    }
}
