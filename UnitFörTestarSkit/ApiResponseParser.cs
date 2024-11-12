using System.Text.Json;
using testarskit.Mock.Entities;

namespace UnitFörTestarSkit;

public class ApiResponseParser
{
    public Person ParsePerson(string json)
    {
        return JsonSerializer.Deserialize<Person>(json);
    }
}