public static class AllYourBase
{
    public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
    {
        if (outputBase < 2 || inputBase < 2)
            throw new ArgumentException("inputBase and outputBase must be at least 2");

        var num = ConvertToDec(inputBase, inputDigits);

        List<int> outputDigits = new();
        if (num == 0) return new int[] { 0 };

        while (num > 0)
        {
            outputDigits.Add(num % outputBase);
            num /= outputBase;
        }

        outputDigits.Reverse();
        return outputDigits.ToArray();
    }

    private static int ConvertToDec(int inputBase, int[] inputDigits)
    {
        int sum = 0;

        foreach (var digit in inputDigits)
        {
            if (digit < 0 || digit >= inputBase)
                throw new ArgumentException("Invalid digit for given base.");

            sum = sum * inputBase + digit;
        }

        return sum;
    }
}
