using testarskit.Övningar;

namespace UnitFörTestarSkit.TestClasses;

public class DictionaryRemoveTest
{
    [Fact]
    public static void RemoveEntry_WithValidInput_RemovesEntry()
    {
        // arrange

        string entry = "Hej jag gillar kiss";
        string key = "2";
        Diary.AddToRemoveEntry(entry, key);

        // act

        Diary.RemoveEntry(key);

        // assert
        Assert.Empty(Diary.RemoveEntries);
    }
}