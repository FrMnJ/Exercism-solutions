using System.Collections.Generic;

public static class PrimeFactors
{
    public static long[] Factors(long number)
    {
        List<long> res = new();

        // Factor out 2s
        while (number % 2 == 0)
        {
            res.Add(2);
            number /= 2;
        }

        // Factor odd numbers up to sqrt(number)
        for (long i = 3; i * i <= number; i += 2)
        {
            while (number % i == 0)
            {
                res.Add(i);
                number /= i;
            }
        }

        // If remainder is > 1, it's prime
        if (number > 1)
            res.Add(number);

        return res.ToArray();
    }
}
