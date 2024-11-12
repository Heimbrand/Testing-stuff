using FakeItEasy;
using testarskit.Mock.Interfaces;
using testarskit.Repositories;

namespace UnitFörTestarSkit.TestClasses;

public class ConfigurationTests
{
    private readonly IConfigurationManager _configManager;
    private readonly ConfigService _configService;

    public ConfigurationTests()
    {
      _configManager = A.Fake<IConfigurationManager>();
      _configService = new ConfigService(_configManager);
    }

    [Fact]
    public void GetSetting_ShouldReturnSetting()
    {
      // Arrange
      string key = "TestKey";
      string value = "TestValue";

      // Act

       _configService.GetSetting(key);

       // Assert
       A.CallTo(() => _configManager.GetSetting(key)).MustHaveHappenedOnceExactly();
    }
    [Fact]
    public void SetSetting_ShouldSetSetting()
    {
      // Arrange
      string key = "TestKey";
      string value = "TestValue";

      // Act
      _configService.SetSetting(key, value);

      // Assert
      A.CallTo(() => _configManager.SetSetting(key, value)).MustHaveHappenedOnceExactly();
    }
}