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
        int aliquotSum = 0;
        for(int i = 1; i < number; i++){
            if(number % i == 0)
                aliquotSum += i;
        }
        if(aliquotSum == number) return Classification.Perfect;
        else if(aliquotSum < number) return Classification.Deficient;
        else return Classification.Abundant;
    }
}
