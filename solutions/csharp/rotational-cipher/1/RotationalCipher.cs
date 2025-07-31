
public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
        => text.Select(c => RotateCharacter(c, shiftKey))
            .Aggregate(string.Empty, (current, next) => current + next);
    private static char RotateCharacter(char c, int shiftKey) => c switch
    {
        >= 'a' and <= 'z' => (char)((c - 'a' + shiftKey) % 26 + 'a'),
        >= 'A' and <= 'Z' => (char)((c - 'A' + shiftKey) % 26 + 'A'),
        _ => c
    };
}