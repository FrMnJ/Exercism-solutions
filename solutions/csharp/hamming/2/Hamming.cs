public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
        => firstStrand.Length == secondStrand.Length
            ? firstStrand.Zip(secondStrand).Count(pair =>  pair.First != pair.Second)
            : throw new ArgumentException("Strands must be of equal length.");
}