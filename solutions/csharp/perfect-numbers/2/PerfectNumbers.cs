public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if(number < 1) throw new ArgumentOutOfRangeException(nameof(number));
        int aliquotSum = Enumerable.Range(1, number-1).Where(n => number % n == 0).Sum();
        return (aliquotSum < number, aliquotSum > number) switch{
                (true, _) => Classification.Deficient,
                (_, true) => Classification.Abundant,
                _ => Classification.Perfect
        };
    }
}
