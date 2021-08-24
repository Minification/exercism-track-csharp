using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length) {
        	throw new ArgumentException("Strands must have same length!");
        }
        return firstStrand.Zip(secondStrand, (first, second) => first != second).Count((e) => e);
    }
}
