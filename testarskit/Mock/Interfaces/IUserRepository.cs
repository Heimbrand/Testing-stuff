using testarskit.Mock.Entities;

namespace testarskit.Mock.Interfaces;

public interface IUserRepository
{
    void AddUser(User user);
    void UpdateUser(User user);
    User GetUserById(int id);
    void DeleteUser(int id);
}