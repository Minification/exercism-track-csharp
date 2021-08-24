using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
    
    private static readonly char[] Nucleotides = new[] { 'A', 'C', 'G', 'T' };
    
    public static IDictionary<char, int> Count(string sequence)
    {
        return sequence
            .Concat(Nucleotides) // Just sprinkle in one nucleotide each...
            .Select(s => {
                //Check for bad input...
                return Nucleotides.Any(n => n == s) ? s : throw new ArgumentException($"Unknown nucleotide {s}!");
            })
            .GroupBy(s => s)
            .ToDictionary(g => g.Key, g => g.ToList().Count()-1);
            //                                                ^ 
            //                             and forget about the added ones again...
    }
}
