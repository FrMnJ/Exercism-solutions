using System.Collections.ObjectModel;

public class SpaceAge
{
    private const int EARTH_SECONDS_IN_YEAR = 31_557_600;
    private readonly ReadOnlyDictionary<string, double> orbital_ratios = new ReadOnlyDictionary<string, double>(new Dictionary<string, double>()
    {
        { "Mercury", 0.2408467 },
        { "Venus",   0.61519726 },
        { "Mars",   1.8808158 },
        { "Jupiter", 11.862615 },
        { "Saturn",  29.447498 },
        { "Uranus",  84.016846 },
        { "Neptune", 164.79132 }
    });
    private readonly int seconds;

    public SpaceAge(int seconds)
    {
        this.seconds = seconds;
    }

    public double OnEarth()
        => seconds / (double)EARTH_SECONDS_IN_YEAR;


    public double OnMercury()
        => OnEarth() / orbital_ratios["Mercury"];

    public double OnVenus()
        => OnEarth() / orbital_ratios["Venus"];

    public double OnMars()
        => OnEarth() / orbital_ratios["Mars"];

    public double OnJupiter()
        => OnEarth() / orbital_ratios["Jupiter"];

    public double OnSaturn()
        => OnEarth() / orbital_ratios["Saturn"];

    public double OnUranus()
        => OnEarth() / orbital_ratios["Uranus"];

    public double OnNeptune()
        => OnEarth() / orbital_ratios["Neptune"];
}