namespace testarskit.Mock.Interfaces;

public interface IRepository
{
    string Get(int id);
    void Add(int id);
    void Remove(int id);
}