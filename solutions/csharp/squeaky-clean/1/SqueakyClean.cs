using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < identifier.Length; i++)
        {
            if (Char.IsWhiteSpace(identifier[i]))
            {
                result.Append('_');
                continue;
            }
            if (Char.IsControl(identifier[i]))
            {
                result.Append("CTRL");
                continue;
            }
            if (identifier[i] == '-' && (i + 1) < identifier.Length && char.IsLetter(identifier[i + 1]))
            {
                i++;
                result.Append( char.ToUpper(identifier[i]) );
                continue;
            }
            if ((!char.IsLetter(identifier[i]) && identifier[i] != '_') || char.IsBetween(identifier[i], 'α', 'ω'))
            {
                continue;
            }

            result.Append(identifier[i]);
        }
        return result.ToString();
    }
}
