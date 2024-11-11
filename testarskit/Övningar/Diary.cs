namespace testarskit.Övningar;

public static class Diary
{
   public static Dictionary<string, string> AddEntries = new();
   public static Dictionary<string, string> RemoveEntries = new();

    public static void AddEntry(string entry, string key)
    {
        AddEntries.Add(entry, key);
    }
    public static void AddToRemoveEntry(string entry, string key)
    {
        RemoveEntries.Add(entry, key);
    }
    public static void RemoveEntry(string key)
    {
        var entry = RemoveEntries.FirstOrDefault(x => x.Value == key);
        RemoveEntries.Remove(entry.Key);
    }
}