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
        public async Task<CreatePositionReponseModel> CreatePositionAsync(CreatePositionModel position)
        {
            var positionEntity = _mapper.Map<Position>(position);
            var entity = await _positionRepository.AddAsync(positionEntity);
            return _mapper.Map<CreatePositionReponseModel>(entity);
        }

        public async Task<List<PositionModel>> GetAllPositionAsync(PositionFilter filter, Order order, Pagination pagination)
        {
            var entities = await _positionRepository.GetAllAsync(filter, order, pagination);
            return _mapper.Map<List<PositionModel>>(entities);
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
