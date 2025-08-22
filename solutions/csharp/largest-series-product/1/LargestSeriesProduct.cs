public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {
        if (span < 0)
            throw new ArgumentException("Span must be non-negative.");
        if (span > digits.Length)
            throw new ArgumentException("Span cannot be larger than the number of digits.");
        if (!digits.All(char.IsDigit))
            throw new ArgumentException("Input must contain only digits.");
        if (span == 0)
            return 1;

        long largest = 0;
        long current = 1;
        int zeroCount = 0;
        int start = 0;

        for (int end = 0; end < digits.Length; end++)
        {
            int digit = digits[end] - '0';

            if (digit == 0)
            {
                zeroCount++;
            }
            else
            {
                current *= digit;
            }

            if (end - start + 1 > span)
            {
                int leftDigit = digits[start] - '0';
                if (leftDigit == 0)
                {
                    zeroCount--;
                }
                else
                {
                    current /= leftDigit;
                }
                start++;
            }
            if (end - start + 1 == span)
            {
                if (zeroCount == 0)
                {
                    largest = Math.Max(largest, current);
                }
                else
                {
                    largest = Math.Max(largest, 0);
                }
            }
        }

        return largest;
    }
}
