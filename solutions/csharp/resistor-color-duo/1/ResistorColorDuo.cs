enum ResistorColor{
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

public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        int res = (int)Enum.Parse(typeof(ResistorColor), colors[1], true);
        res += 10 * (int)Enum.Parse(typeof(ResistorColor), colors[0], true);
        return res;
    }
}
