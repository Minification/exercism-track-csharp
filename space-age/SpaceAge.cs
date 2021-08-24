using System;

public class SpaceAge
{

    private const double _earthYearsInSeconds = 31557600.0;

    private readonly double _secondsAsEarthYears;

    public SpaceAge(int seconds)
    {
        this._secondsAsEarthYears = seconds / _earthYearsInSeconds;
    }

    private double toPlanetYears(double earthYearsOnPlanet) => _secondsAsEarthYears / earthYearsOnPlanet;

    public double OnEarth() => _secondsAsEarthYears;

    public double OnMercury() => toPlanetYears(0.2408467);

    public double OnVenus() => toPlanetYears(0.61519726);

    public double OnMars() => toPlanetYears(1.8808158);

    public double OnJupiter() => toPlanetYears(11.862615);

    public double OnSaturn() => toPlanetYears(29.447498);

    public double OnUranus() => toPlanetYears(84.016846);

    public double OnNeptune() => toPlanetYears(164.79132);

}