using testarskit.Mock.Entities;
using testarskit.Mock.Interfaces;

namespace testarskit.Repositories;

public class UserService(IUserRepository repo)
{
    public void AddUser(User user)
    {
        repo.AddUser(user);
    }
    public void UpdateUser(User user)
    {
        repo.UpdateUser(user);
    }
    public User GetUserById(int id)
    {
        return repo.GetUserById(id);
    }
    public void DeleteUser(int id)
    {
        repo.DeleteUser(id);
    }
}