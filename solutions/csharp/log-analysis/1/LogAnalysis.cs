public static class LogAnalysis 
{
    public static string SubstringAfter(this string source, string value)
    {
        int index = source.IndexOf(value);
        if (index < 0) return string.Empty;
        return source[(index + value.Length)..];
    }

    public static string SubstringBetween(this string source, string start, string end)
    {
        int startIndex = source.IndexOf(start);
        if (startIndex < 0) return string.Empty;
        startIndex += start.Length;
        int endIndex = source.IndexOf(end, startIndex);
        if (endIndex < 0) return string.Empty;
        return source[startIndex..endIndex];
    }

    public static string Message(this string log)
        => log.SubstringAfter(": ");
    
    public static string LogLevel(this string log)
        => log.SubstringBetween("[", "]");
    
}