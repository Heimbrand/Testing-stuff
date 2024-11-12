using testarskit.Mock.Interfaces;

namespace testarskit.Repositories;

public class AuhenticateService(IAuthenticationService repo)
{
    public bool Authenticate(string username, string password)
    {
        return repo.Authenticate(username, password);
    }
}