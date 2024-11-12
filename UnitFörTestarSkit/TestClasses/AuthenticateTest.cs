using FakeItEasy;
using testarskit.Mock.Interfaces;
using testarskit.Repositories;

namespace UnitFörTestarSkit.TestClasses;

public class AuthenticateTest
{
    private readonly IAuthenticationService _repo;
    private readonly AuhenticateService _service;

    public AuthenticateTest()
    {
        _repo = A.Fake<IAuthenticationService>();
        _service = new AuhenticateService(_repo);
    }

    [Fact]
    public void AuthenticateTest_IfTrue()
    {
        // Arrange 
        string username = "Test";
        string password = "Test1";
        A.CallTo(() => _repo.Authenticate(username, password)).Returns(true);

        // Act 
        bool result = _service.Authenticate(username, password);

        // Assert
        Assert.True(result);
    }
}