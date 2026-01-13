public class StringMethods
{
    public static string? ReverseString(string input)
    {
        if (input == null)
            return null;

        char[] charArray = input.ToCharArray();
        System.Array.Reverse(charArray);
        return new string(charArray);
    }

    public static string? MergeStrings(string str1, string str2)
    {
        return str1 + str2;
    }

    public static string? RemoveWhitespace(string input)
    {
        if (input == null)
            return null;

        return string.Concat(input.Where(c => !char.IsWhiteSpace(c)));
    }
}