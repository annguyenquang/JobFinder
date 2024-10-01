
using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.Model;

namespace JobFinder.Service
{
    public class PositionService(IPositionRepository _positionRepository, IMapper _mapper) : IPositionService
    {
        public async Task<CreatePositionReponseModel> CreatePositionAsync(CreatePositionModel position )
        {
            var positionEntity = _mapper.Map<Position>(position);
            var entity = await _positionRepository.AddAsync(positionEntity);
            return _mapper.Map<CreatePositionReponseModel>(entity);
        }

        public async Task<PositionModel> GetPositionAsync(Guid id)
        {

            var entity = await _positionRepository.GetAsync(id);
            return _mapper.Map<PositionModel>(entity);
        }
    }
}
