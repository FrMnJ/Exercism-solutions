public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char, int> nucleotideCounts = new Dictionary<char, int>
        {
            { 'A', 0 },
            { 'C', 0 },
            { 'G', 0 },
            { 'T', 0 }
        };

        foreach(char nucleotide in sequence)
        {
            if (nucleotideCounts.ContainsKey(nucleotide))
            {
                nucleotideCounts[nucleotide]++;
            }
            else
            {
                throw new ArgumentException($"Invalid nucleotide '{nucleotide}' in sequence.");
            }
        }

        return nucleotideCounts;
    }
}