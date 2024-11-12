namespace testarskit.Mock.Interfaces;

public interface IConfigurationManager
{
    string GetSetting(string key);
    void SetSetting(string key, string value);
}