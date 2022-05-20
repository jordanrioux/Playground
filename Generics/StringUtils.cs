namespace Generics;

public static class StringUtils
{
    public static bool IsWhiteSpace(string value)
    {
        foreach (var c in value)
        {
            if (!char.IsWhiteSpace(c))
            {
                return false;
            }
        }
        return true;
    }

    public static bool IsWhiteSpace2(string value)
    {
        return (value != value.Trim());
    }
}