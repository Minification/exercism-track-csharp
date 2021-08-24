using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{

    private readonly List<int> _scores;

    public HighScores(List<int> list)
    {
        // Copy to protect against list changing
        _scores = list.ToList();
    }

    public List<int> Scores() => _scores.ToList();

    public int Latest() => _scores.Last();

    public int PersonalBest() => _scores.Max(score => score);

    public List<int> PersonalTopThree() => _scores.OrderByDescending(score => score).Take(3).ToList();
}