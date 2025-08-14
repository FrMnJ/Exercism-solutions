public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength <= 0 || sliceLength > numbers.Length)
            throw new ArgumentException(
                "Must be greater than 0 and less than or equal to numbers string length.",
                nameof(sliceLength)
            );

        return Enumerable.Range(0, numbers.Length - sliceLength + 1)
            .Select(i => numbers.Substring(i, sliceLength))
            .ToArray();
    }
}
