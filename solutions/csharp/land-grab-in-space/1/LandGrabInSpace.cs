public struct Coord
{
    public Coord(ushort x, ushort y)
    {
        X = x;
        Y = y;
    }

    public ushort X { get; }
    public ushort Y { get; }
}

public struct Plot
{
    public Plot(Coord a, Coord b, Coord c, Coord d)
    {
        A = a;
        B = b;
        C = c;
        D = d;
    }
    public Coord A { get; }
    public Coord B { get; }
    public Coord C { get; }
    public Coord D { get; }

}


public class ClaimsHandler
{
    private readonly List<Plot> claims = new();

    public void StakeClaim(Plot plot)
    {
        if (!claims.Contains(plot))
        {
            claims.Add(plot);
        }
    }


    public bool IsClaimStaked(Plot plot) => claims.Contains(plot);

    public bool IsLastClaim(Plot plot) => claims.Count > 0 && claims[^1].Equals(plot);

    public Plot GetClaimWithLongestSide()
    {
        double longestDistance = -1;
        Plot longestPlot = default;

        for (int i = 0; i < claims.Count; i++)
        {
            List<double> distances = new List<double>
            {
                Distance(claims[i].A, claims[i].B),
                Distance(claims[i].B, claims[i].C),
                Distance(claims[i].C, claims[i].D),
                Distance(claims[i].D, claims[i].A)
            };
            distances.Sort();
            double longest = distances[3]; 
            if (longest > longestDistance)
            {
                longestDistance = longest;
                longestPlot = claims[i];
            }
        }
        return longestPlot;
    }

    private double Distance(Coord a, Coord b)
    {
        double dx = Math.Pow(a.X - b.X, 2);
        double dy = Math.Pow(a.Y - b.Y, 2);
        return (int)Math.Sqrt(dx + dy);
    }
}
