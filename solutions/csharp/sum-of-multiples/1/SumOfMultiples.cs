public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        HashSet<int> mult = new();
        foreach(var multiple in multiples){
            if(multiple == 0) continue;
            for(int i = 1; i * multiple < max; i++){
                mult.Add(i*multiple);
            }
        }
        return mult.Sum();
    }
}