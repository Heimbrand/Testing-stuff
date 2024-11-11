namespace testarskit.Övningar;

public static class ReversaSträng
{
    public static string ReverseStrings(string input)
    {
        var reversed = new string(input.Reverse().ToArray());

        return reversed;
    }

}