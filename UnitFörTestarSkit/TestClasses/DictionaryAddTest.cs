using testarskit.Övningar;

namespace UnitFörTestarSkit.TestClasses;

public class DictionaryAddTest
{
    [Fact]
    public static void AddEntry_WithValidInput_AddsEntry()
    {
        // arrange
        string entry = "Hej jag gillar ´bajs";
        string key = "1";

        // act
        Diary.AddEntry(entry, key);

        // assert
        Assert.Single(Diary.AddEntries);
    }
}