
using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.Model;
using JobFinder.Model.Position;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System.Reflection;
using System.Runtime.InteropServices;

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

        public async Task<UpdatePositionReponseModel> UpdatePositionAsync1(Guid id, UpdatePositionModel positionModel)
        {
            Position existingPosition = await _positionRepository.GetAsync(id);
            //  
            existingPosition.Title = positionModel.Title;
            //existingPosition.Description = positionModel.Description;
            //existingPosition.Salary = positionModel.Salary ?? 0;
            if (positionModel.CloseDate.HasValue)
            {
                existingPosition.CloseDate = positionModel.CloseDate ?? DateTime.Now;
            }
            
            var res = await _positionRepository.UpdateAsync(existingPosition);
            return _mapper.Map<UpdatePositionReponseModel>(res);


        }
    }
}
