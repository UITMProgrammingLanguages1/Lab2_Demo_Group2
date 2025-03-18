public static class Utilities
{
    public static string ToSentence(this string input)
    {
        return input.Substring(0, 1).ToUpper() + input.Substring(1).ToLower(); //copilot generated
    }
}