namespace testarskit.Övningar;

public static class UserValidation_
{
    public static bool ValidateUser(string hotMail, string password)
    {
        if (hotMail == "Olle.Heimbrand@hotmail.se" && password == "admin")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool ValidateHotmailFormat(string hotMail)
    {
        if (hotMail.Contains("@hotmail.se"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool ValidatePasswordLength(string password)
    {
        if (password.Length >= 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}