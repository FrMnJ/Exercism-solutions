public static class VariableLengthQuantity
{
    public static uint[] Encode(uint[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return Array.Empty<uint>();
        }
        var encodedBytes = new List<uint>();
        foreach (var number in numbers)
        {
            uint[] encoded = EncodeNumber(number);
            encodedBytes.AddRange(encoded);
        }
        return encodedBytes.ToArray();
    }

    private static uint[] EncodeNumber(uint number)
    {
        if (number == 0)
            return new uint[] { 0 };

        var result = new List<uint>();

        while (number > 0)
        {
            uint chunk = number & 0x7F;
            result.Add(chunk);
            number >>= 7;
        }

        // Reverse the chunks so the most significant comes first
        result.Reverse();

        // Set the MSB on all but the last
        for (int i = 0; i < result.Count - 1; i++)
        {
            result[i] |= 0x80;
        }

        return result.ToArray();
    }

    public static uint[] Decode(uint[] bytes)
    {
        var decodedNumbers = new List<uint>();
        uint number = 0;

        foreach (var b in bytes)
        {
            number = (number << 7) | (b & 0x7F);

            if ((b & 0x80) == 0) 
            {
                decodedNumbers.Add(number);
                number = 0;
            }
        }

        if ((bytes[^1] & 0x80) != 0)
        {
            throw new InvalidOperationException("Incomplete VLQ sequence: last byte indicates continuation.");
        }

        return decodedNumbers.ToArray();
    }
}