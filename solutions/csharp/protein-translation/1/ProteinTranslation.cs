using System;
using System.Collections.Generic;

public static class ProteinTranslation
{
    private static readonly Dictionary<string, string> codons = new()
    {
        {"AUG", "Methionine"},
        {"UUU", "Phenylalanine"},
        {"UUC", "Phenylalanine"},
        {"UUA", "Leucine"},
        {"UUG", "Leucine"},
        {"UCU", "Serine"},
        {"UCC", "Serine"},
        {"UCA", "Serine"},
        {"UCG", "Serine"},
        {"UAU", "Tyrosine"},
        {"UAC", "Tyrosine"},
        {"UGU", "Cysteine"},
        {"UGC", "Cysteine"},
        {"UGG", "Tryptophan"}
    };

    private static readonly HashSet<string> stopCodons = new() { "UAA", "UAG", "UGA" };

    public static string[] Proteins(string strand)
    {
        List<string> res = new();

        for (int i = 0; i + 2 < strand.Length; i += 3)
        {
            string codon = strand.Substring(i, 3);

            if (stopCodons.Contains(codon))
                break;

            if (codons.TryGetValue(codon, out string protein))
                res.Add(protein);
            else
                continue;
        }

        return res.ToArray();
    }
}
