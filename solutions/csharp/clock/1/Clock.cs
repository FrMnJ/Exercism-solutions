public class Clock
{
    private int hours;
    private int minutes;


    public Clock(int hours, int minutes)
    {
        int totalMinutes = (hours * 60 + minutes) % 1440;

        if (totalMinutes < 0)
            totalMinutes += 1440;

        this.hours = totalMinutes / 60;
        this.minutes = totalMinutes % 60;
    }

    public Clock Add(int minutesToAdd)
    {
        int result = (minutesToAdd + (hours * 60 + minutes)) % 1440;
        if (result < 0)
            result += 1440;
        return new Clock(result / 60, result % 60);
    }

    public Clock Subtract(int minutesToSubtract)
    {
        int result = ((hours * 60 + minutes) - minutesToSubtract) % 1440;
        if (result < 0)
            result += 1440;
        return new Clock(result / 60, result % 60);
    }

    public override string ToString() => $"{hours:00}:{minutes:00}";

    public override bool Equals(object? obj)
    {
        if (obj is Clock other)
        {
            return hours == other.hours && minutes == other.minutes;
        }
        return false;
    }
}