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
}