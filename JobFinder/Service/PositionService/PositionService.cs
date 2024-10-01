
using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.Model;

namespace JobFinder.Service
{
    public class PositionService(IPositionRepository _positionRepository, IMapper _mapper) : IPositionService
    {
        public async Task<PositionModel> GetPosition(Guid id)
        {

            var entity = await _positionRepository.GetAsync(id);
            return _mapper.Map<PositionModel>(entity);
        }
    }
}
