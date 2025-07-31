using System.Text.RegularExpressions;

public class LogParser
{
    public bool IsValidLine(string text)
    {
        string pattern = @"^\[(TRC|DBG|INF|WRN|ERR|FTL)\] .+$";
        return Regex.IsMatch(text, pattern);
    }

    public string[] SplitLogLine(string text)
    {
        string pattern = @"<[\^*=-]+>";
        return Regex.Split(text, pattern);
    }

    public int CountQuotedPasswords(string lines)
    {
        string pattern = "\".*?password.*?\"";
        return Regex.Matches(lines.ToLower(), pattern).Count;
    }

    public string RemoveEndOfLineText(string line)
    {
        string pattern = @"end-of-line\d+";
        return Regex.Replace(line, pattern, string.Empty);
    }

    public string[] ListLinesWithPasswords(string[] lines)
    {
        string pattern = @"\b(password\w+)\b";
        var result = new List<string>();
        foreach (var line in lines)
        {
            var match = Regex.Match(line, pattern, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                result.Add($"{match.Groups[1].Value}: {line}");
            }
            else
            {
                result.Add($"--------: {line}");
            }
        }
        return result.ToArray();
    }
}
