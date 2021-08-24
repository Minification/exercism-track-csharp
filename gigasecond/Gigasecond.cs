using System;

public static class Gigasecond
{

    private const long GIGASECOND = (long) 1e9; 

    public static DateTime Add(DateTime moment) => moment.AddSeconds(Gigasecond.GIGASECOND);
}