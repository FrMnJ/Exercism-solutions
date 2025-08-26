public static class Darts
{
    public static int Score(double x, double y)
        => DistanceOrigin(x, y) switch{
            <= 1 => 10,
            <= 5 => 5,
            <= 10 => 1,
            _ => 0
        };

    private static double DistanceOrigin(double x, double y)
        => Math.Sqrt(x*x+y*y);
}
