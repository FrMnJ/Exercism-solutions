static class AssemblyLine
{
    public static double SuccessRate(int speed) => speed switch
    {
        < 1 => 0.0,
        < 5 => 1.0,
        < 9 => 0.9,
        9 => 0.8,
        > 9 => 0.77,
    };

    public static double ProductionRatePerHour(int speed) => SuccessRate(speed) * speed * 221.0;

    public static int WorkingItemsPerMinute(int speed) => (int) ProductionRatePerHour(speed) / 60;
}
