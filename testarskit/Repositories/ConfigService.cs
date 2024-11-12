using testarskit.Mock.Interfaces;

namespace testarskit.Repositories;

public class ConfigService(IConfigurationManager repo)
{
    public string GetSetting(string key)
    {
        return repo.GetSetting(key);
    }
    public void SetSetting(string key, string value)
    {
        repo.SetSetting(key, value);
    }
}