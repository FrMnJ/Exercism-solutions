public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if(sliceLength <= 0 || sliceLength > numbers.Length) 
            throw new ArgumentException(nameof(sliceLength), "Must be greater than 0 and less than or equal to numbers string length.");
        IEnumerable<string> slices = Slice(numbers, sliceLength);
        return slices.ToArray();
    }

    private static IEnumerable<string> Slice(string number, int sliceLength){
        
        for(int i = 0;
            i <= number.Length - sliceLength;
            i++){
            yield return new string(number.Skip(i).Take(sliceLength).ToArray());
        }
    }
}