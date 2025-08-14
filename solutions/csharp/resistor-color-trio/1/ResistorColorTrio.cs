public static class ResistorColorTrio
{
    enum ResistorColor {
        Black,
        Brown,
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Violet,
        Grey,
        White
    }
    
    public static string Label(string[] colors)
    {
        long first = (long)ParseResistorColor(colors[0]);
        long second = (long)ParseResistorColor(colors[1]);
        long multiplier = (long)ParseResistorColor(colors[2]);
    
        long res = (first * 10 + second) * (long)Math.Pow(10, multiplier);
    
        if (res >= 1_000_000_000) return $"{res / 1_000_000_000} gigaohms";
        if (res >= 1_000_000) return $"{res / 1_000_000} megaohms";
        if (res >= 1_000) return $"{res / 1_000} kiloohms";
        return $"{res} ohms";
    }


    private static ResistorColor ParseResistorColor(string color)
    {
        if (!Enum.TryParse(color, true, out ResistorColor result))
            throw new ArgumentException($"Invalid resistor color: {color}");
        return result;
    }
}
