using System.Linq.Expressions;
using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.DataAccess.Persistent;
using JobFinder.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace JobFinder.Service;

public class UserService(DatabaseContext databaseContext, IMapper mapper) : IUserService
{
    private readonly DbSet<User> _userDbSet = databaseContext.Users;
    public async Task<UserModel> GetUserById(Guid id)
    {
        var entity = await _userDbSet.FindAsync(id);
        return mapper.Map<UserModel>(entity);
    }

    public async Task<UpdateUserResponseModel> UpdateUserById(Guid id, UpdateUserModel user)
    {
        var userEntity = await _userDbSet.FindAsync(id);
        if(userEntity == null) 
            throw new BadRequestException($"User with not found");
        userEntity.FirstName = user.FirstName;
        userEntity.LastName = user.LastName;
        if (user.DateOfBirth != null)
        {
            userEntity.DateOfBirth = user.DateOfBirth.Value; 
        }
        userEntity.Certifications = user.Certifications;
        userEntity.Skills = user.Skills;
        userEntity.SelfDescription = user.SelfDescription;
        Expression<Func<SetPropertyCalls<User>, SetPropertyCalls<User>>> updateExpression =
            setter => setter.SetProperty(u => u.FirstName, user.FirstName)
                .SetProperty(u => u.LastName, user.LastName)
                .SetProperty(u => u.Certifications, user.Certifications)
                .SetProperty(u => u.Skills, user.Skills)
                .SetProperty(u => u.SelfDescription, user.SelfDescription)
                .SetProperty(u => u.DateOfBirth, user.DateOfBirth ?? user.DateOfBirth);
        var res = await _userDbSet.ExecuteUpdateAsync(updateExpression);
        return mapper.Map<UpdateUserResponseModel>(res);
    }
}