


public static class MatchingBrackets
{
    public static bool IsPaired(string input)
    {
        input = new String(input.Trim().Where(IsBracket).ToArray());
        var stack = new Stack<char>();
        foreach (var c in input)
        {
            if(IsStartingBracket(c)) stack.Push(c.MatchingPair());
            else if (IsEndingBracket(c))
            {
                if (stack.Count == 0 || c != stack.Pop())
                    return false;
            }
        }
        return stack.Count == 0;
    }
    private static char MatchingPair(this char current)
        => current switch
        {
            '(' => ')',
            '{' => '}',
            '[' => ']',
            _ => throw new ArgumentException("Invalid character")
        };
    private static bool IsEndingBracket(char c) => c == ')' || c == '}' || c == ']';
    private static bool IsStartingBracket(char c) => c == '(' || c == '{' || c == '[';
    private static bool IsBracket(char c)
        => c == '(' || c == ')' || c == '{' || c == '}' || c == '[' || c == ']';
}
