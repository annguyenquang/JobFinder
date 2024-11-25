using JobFinder.Model;

namespace JobFinder.Service;

public interface IUserService
{
    Task<UserModel> GetUserById(Guid id);
    Task<UpdateUserResponseModel> UpdateUserById(Guid id, UpdateUserModel user);
}
