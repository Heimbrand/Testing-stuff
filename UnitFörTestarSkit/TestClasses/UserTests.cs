using testarskit.Repositories;
using FakeItEasy;
using testarskit.Mock.Interfaces;
using testarskit.Mock.Entities;

namespace UnitFörTestarSkit.TestClasses;

public class UserTests
{
    private readonly UserService _service;
    private readonly IUserRepository _repo;

    public UserTests()
    {
        _repo = A.Fake<IUserRepository>();
        _service = new UserService(_repo);
    }
    [Fact]
    public void AddUserTest()
    {
        List<User> users = new();
       // Arrange 
       User user = new User
       {
           Id = 1,
           Name = "Test",
           Password = "Test1"
       };
       A.CallTo(() => _repo.AddUser(user)).Invokes((User u) => users.Add(u));

       // Act 
       _service.AddUser(user);

       // Assert
       A.CallTo(() => _repo.AddUser(user)).MustHaveHappenedOnceExactly();
       Assert.Contains(user, users);
       
    }
    [Fact]
    public void UpdateUserTest()
    {
       // Arrange 
       User user = new User
       {
           Id = 1,
           Name = "Test",
           Password = "Test1"
       };
       A.CallTo(() => _repo.UpdateUser(user));

       // Act 
       _service.UpdateUser(user);

       // Assert
       A.CallTo(() => _repo.UpdateUser(user)).MustHaveHappenedOnceExactly();
    }
    [Fact]
    public void GetUserByIdTest()
    {
       // Arrange 
       User user = new User
       {
           Id = 1,
           Name = "Test",
           Password = "Test1"
       };
       A.CallTo(() => _repo.GetUserById(1)).Returns(user);

       // Act 
       var result = _service.GetUserById(1);

       // Assert
       A.CallTo(() => _repo.GetUserById(1)).MustHaveHappenedOnceExactly();
       Assert.Equal(user, result);
    }
    [Fact]
    public void DeleteUserTest()
    {
       // Arrange 
       User user = new User
       {
           Id = 1,
           Name = "Test",
           Password = "Test1"
       };
       A.CallTo(() => _repo.DeleteUser(1));

       // Act 
       _service.DeleteUser(1);

       // Assert
       A.CallTo(() => _repo.DeleteUser(1)).MustHaveHappenedOnceExactly();
    }
   
}