public static class LogAnalysis 
{
    public static string SubstringAfter(this string source, string value)
        => source[(source.IndexOf(value) + value.Length)..];

    public static string SubstringBetween(this string source, string start, string end)
        => source.Substring(source.IndexOf(start) + start.Length, 
                           source.IndexOf(end) - (source.IndexOf(start) + start.Length));

    public static string Message(this string log)
        => log.SubstringAfter(": ");
    
    public static string LogLevel(this string log)
        => log.SubstringBetween("[", "]");
    
}