using System.Text.Json;
using testarskit.Mock;
using testarskit.Mock.Entities;

namespace UnitFörTestarSkit.TestClasses;

public class ApiResponseTests
{
    [Fact]
    public void ParsePerson_WithValidInput_ReturnsPerson()
    {
        // Arrange
        string jsonResponse = "{\"Id\":1,\"Name\":\"Klas\",\"Age\":30}";
        var parser = new ApiResponseParser();
        var expected = new Person
        {
            Id = 1,
            Name = "Klas",
            Age = 30
        };

        // Act
        var actual = parser.ParsePerson(jsonResponse);

        // Assert
        Assert.Equal(expected.Id, actual.Id);
        Assert.Equal(expected.Name, actual.Name);
        Assert.Equal(expected.Age, actual.Age);
    }
    [Fact]
    public void ParsePerson_WithInvalidInput_ThrowsException()
    {
        // Arrange
        string jsonResponse = "{\"Id\":1,\"Name\":\"Klas\"}";  // Age saknas därför bör exception kastas
        var parser = new ApiResponseParser();

        // Act & Assert
        Assert.Throws<JsonException>(() => parser.ParsePerson(jsonResponse));
    }
}