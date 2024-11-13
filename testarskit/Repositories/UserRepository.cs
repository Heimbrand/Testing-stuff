using testarskit.Mock.Entities;
using testarskit.Mock.Interfaces;

namespace testarskit.Repositories;

public class UserRepository(IUserService repo)
{
    void CreateUser(User user)
    {
        repo.CreateUser(user);
    }
    User FindUserById(int id)
    {
       var user = repo.FindUserById(id);

       return user;
    }
    void DeleteUser(int id)
    {
        repo.DeleteUser(id);
    }
}