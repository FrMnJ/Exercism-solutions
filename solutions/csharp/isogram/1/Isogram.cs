public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        word = word.ToLower();
        var set = new HashSet<char>();
        foreach(var c in word)
            if(char.IsLetter(c))
                if(!set.Add(c)) return false;
        return true;      
    }
}
