public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        return (statement.IsShout(),
            statement.IsQuestion(),
            statement.IsSilence()) switch
        {
            (true, true, _) => "Calm down, I know what I'm doing!",
            (true, false, _) => "Whoa, chill out!",
            (_, true, _) => "Sure.",
            (_, _, true) => "Fine. Be that way!",
            _ => "Whatever."
        };
    }
    private static bool IsSilence(this string statement) => string.IsNullOrWhiteSpace(statement);
    private static bool IsQuestion(this string statement) => statement.EndsWith("?");
    private static bool IsShout(this string statement) => statement.Any(char.IsLetter) && statement.ToUpper() == statement;
}