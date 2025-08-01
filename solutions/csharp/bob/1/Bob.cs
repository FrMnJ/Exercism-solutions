public static class Bob
{
    public static string Response(string statement)
    {
        if (statement.Where(c => char.IsLetter(c)).All(c => char.IsUpper(c)) 
            && statement.Any(c => char.IsUpper(c)))
        {
            if(statement.Trim().EndsWith("?"))
            {
                return "Calm down, I know what I'm doing!";
            }
            return "Whoa, chill out!";
        }
        else if (statement.Trim().EndsWith("?")) return "Sure.";
        else if (string.IsNullOrWhiteSpace(statement)) return "Fine. Be that way!";
        return "Whatever.";
    }
}