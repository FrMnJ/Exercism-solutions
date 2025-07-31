class BirdCount
{
    private int[] birdsPerDay;
    private static int[] lastWeekCount = { 0, 2, 5, 3, 7, 8, 4 };

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => lastWeekCount;

    public int Today() => birdsPerDay[birdsPerDay.Length-1];

    public void IncrementTodaysCount() => birdsPerDay[birdsPerDay.Length - 1]++;

    public bool HasDayWithoutBirds() => birdsPerDay.Any(count => count == 0);

    public int CountForFirstDays(int numberOfDays) => birdsPerDay.Take(numberOfDays).Sum();

    public int BusyDays() => birdsPerDay.Count(count => count >= 5);
}
