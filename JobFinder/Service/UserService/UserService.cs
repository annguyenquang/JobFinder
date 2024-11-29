using AutoMapper;
using JobFinder.Core.Repository;
using JobFinder.Model;

namespace JobFinder.Service;

public class UserService(IUserRepository _userRepository, IMapper _mapper) : IUserService
{
    public async Task<UserModel> GetUserById(Guid id)
    {
        var entity = await _userRepository.GetAsync(id);
        return _mapper.Map<UserModel>(entity);
    }

    public async Task<UpdateUserResponseModel> UpdateUserById(Guid id, UpdateUserModel user)
    {
        var userEntity = await _userRepository.GetAsync(id);
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
        var res = await _userRepository.UpdateAsync(entity: userEntity);
        return _mapper.Map<UpdateUserResponseModel>(res);
    }
}