namespace testarskit.Mock.Interfaces;

public interface IAuthenticationService
{
    bool Authenticate(string username, string password);
}