using System.Collections.Concurrent;
using System.Threading.Tasks;

public static class ParallelLetterFrequency
{
    public static Dictionary<char, int> Calculate(IEnumerable<string> texts)
    {
        ConcurrentDictionary<char, int> dic = new();
        Parallel.ForEach(texts, text => {
            text = new String(text.ToLower().Where(char.IsLetter).ToArray());
            foreach(var c in text){
                dic.AddOrUpdate(c, 1, (key, oldValue) => oldValue + 1);
            }
        });
        return new Dictionary<char, int>(dic);
    }
}