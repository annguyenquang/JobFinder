using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Core.Repository;

namespace JobFinder.Service
{
    public class PositionApplicationService(IPositionApplicationRepository _positionApplicationRepo, IMapper _mapper) : IPositionApplicationService
    {
        public async Task<List<PositionApplication>> GetAllPositionApplicationsAsync()
        {
            return await _positionApplicationRepo.GetAllAsync();
        }
    }
}
