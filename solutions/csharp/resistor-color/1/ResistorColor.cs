public static class ResistorColor
{
    enum ResistorColorCode
    {
        Black = 0,
        Brown = 1,
        Red = 2,
        Orange = 3,
        Yellow = 4,
        Green = 5,
        Blue = 6,
        Violet = 7,
        Grey = 8,
        White = 9
    }

    public static int ColorCode(string color)
        => Enum.TryParse<ResistorColorCode>(color, true, out var colorCode) 
            ? (int)colorCode
            : throw new ArgumentException($"Invalid color: {color}");
    

    public static string[] Colors()
        => Enum.GetNames(typeof(ResistorColorCode))
        .Select(color => color.ToLowerInvariant())
        .ToArray();
    
}