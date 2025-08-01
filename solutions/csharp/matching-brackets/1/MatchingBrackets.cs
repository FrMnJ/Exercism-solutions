


public static class MatchingBrackets
{
    public static bool IsPaired(string input)
    {
        input = new String(input.Trim().Where(IsBracket).ToArray());
        var stack = new Stack<char>();
        foreach (var c in input)
        {
            if(IsStartingBracket(c)) stack.Push(c);
            else if (IsEndingBracket(c))
            {
                if (stack.Count == 0 || !IsMatchingPair(stack.Pop(), c))
                    return false;
            }
        }
        return stack.Count == 0;
    }
    private static bool IsMatchingPair(char popped, char current)
    {
        char expectedStart = current switch
        {
            ')' => '(',
            '}' => '{',
            ']' => '[',
            _ => throw new ArgumentException("Invalid character")
        };
        return popped == expectedStart;
    }
    private static bool IsEndingBracket(char c) => c == ')' || c == '}' || c == ']';
    private static bool IsStartingBracket(char c) => c == '(' || c == '{' || c == '[';
    private static bool IsBracket(char c)
        => c == '(' || c == ')' || c == '{' || c == '}' || c == '[' || c == ']';
}
