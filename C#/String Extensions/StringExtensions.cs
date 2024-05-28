using System.Text;

namespace StringUtility;

public static class StringExtensions
{
    public static string Reverse(this string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentOutOfRangeException(nameof(value), "Value is null or empty");

        var reversedString = new StringBuilder();
        var lengthOfString = value.Length - 1;

        for (int i = lengthOfString; i >= 0; i--)
            reversedString.Append(value[i]);

        return reversedString.ToString();
    }

    public static bool IsRecursiveAcronym(this string value, bool useWordCase = false)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentOutOfRangeException(nameof(value), "Value is null or empty");

        var reversedWord = value.Reverse();

        return useWordCase ? value.Equals(reversedWord) : value.Equals(reversedWord, StringComparison.CurrentCultureIgnoreCase);
    }
}
