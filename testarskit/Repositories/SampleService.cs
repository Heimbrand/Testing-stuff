using testarskit.Mock.Interfaces;

namespace testarskit.Repositories;

public class SampleService(IRepository repo)
{
    public string Get(int id)
    {
        return repo.Get(id);
    }
    public void Add(int id)
    {
        repo.Add(id);
    }
    public void Remove(int id)
    {
        repo.Remove(id);
    }
}