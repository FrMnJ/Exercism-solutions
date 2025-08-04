using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        
        phrase = phrase.ToUpper().Trim();

        
        phrase = Regex.Replace(phrase, @"[^A-Z\s-]", "");

        
        return new string(
            phrase.Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries)
                  .Select(word => word[0])
                  .ToArray()
        );
    }
}
