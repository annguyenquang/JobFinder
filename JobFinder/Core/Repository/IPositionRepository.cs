﻿using JobFinder.Core.Entity;

namespace JobFinder.Core.Repository
{
    public interface IPositionRepository : IBaseRepository<Position>
    {
        Task<Position> UpdateAsync(Guid id, Position newPosition);
    }
}
