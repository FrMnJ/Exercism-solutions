using System.Collections.Generic;

public static class BottleSong
{
   private static string ToString(int n)
    => n switch
    {
        0 => "no",
        1 => "One",
        2 => "Two",
        3 => "Three",
        4 => "Four",
        5 => "Five",
        6 => "Six",
        7 => "Seven",
        8 => "Eight",
        9 => "Nine",
        10 => "Ten",
        _ => "Unknown"
    };

    private static string S(int n) => n != 1 ? "s" : "";
    
    public static IEnumerable<string> Recite(int startBottles, int takeDown)
{
    const string middle = "And if one green bottle should accidentally fall,";
    int init = startBottles;
    while(takeDown > 0 && startBottles > 0)
    {
        string start  = $"{ToString(startBottles)} green bottle{S(startBottles)} hanging on the wall,";
        string end = $"There'll be {ToString(startBottles - 1).ToLower()} green bottle{S(startBottles - 1)} hanging on the wall.";
        if(startBottles < init)
            yield return "";
        
        yield return start;
        yield return start;
        yield return middle;
        yield return end;

        startBottles--;
        takeDown--;
    }
}

}
