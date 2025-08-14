public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength <= 0 || sliceLength > numbers.Length)
            throw new ArgumentException(
                "Must be greater than 0 and less than or equal to numbers string length.",
                nameof(sliceLength)
            );

        return SlicesIterator(numbers, sliceLength).ToArray();
    }

    private static IEnumerable<string> SlicesIterator(string numbers, int sliceLength)
    {
        for (int i = 0; i <= numbers.Length - sliceLength; i++)
        {
            yield return numbers.Substring(i, sliceLength);
        }
    }
}
