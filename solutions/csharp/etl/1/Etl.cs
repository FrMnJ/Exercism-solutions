public static class Etl
{
    
    
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        Dictionary<string, int> n = new();
        foreach(var kv in old){
            int points = kv.Key;
            foreach(var value in kv.Value){
                n.Add(value.ToLower(), points);
            }
        }
        return n;
    }
}