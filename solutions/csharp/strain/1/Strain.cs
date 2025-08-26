public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        foreach(var ele in collection){
            if(predicate(ele)) yield return ele;
        }
    }

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        foreach(var ele in collection){
            if(!predicate(ele)) yield return ele;
        }
    }
}