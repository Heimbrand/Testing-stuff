using testarskit.Mock.Entities;

namespace testarskit.Mock.Interfaces;

public interface IUserService
{
    void CreateUser(User user);
    User FindUserById(int id);
    void DeleteUser(int id);
}