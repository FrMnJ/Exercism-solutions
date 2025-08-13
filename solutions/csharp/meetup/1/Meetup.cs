public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    private readonly int year;
    private readonly int month;

    public Meetup(int month, int year)
    {
        this.month = month;
        this.year = year;
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        switch (schedule)
        {
            case Schedule.Teenth:
                var teenthDate = new DateTime(year, month, 13);
                while (teenthDate.DayOfWeek != dayOfWeek)
                {
                    teenthDate = teenthDate.AddDays(1);
                }
                return teenthDate;

            case Schedule.First:
                return GetNthWeekdayOfMonth(1, dayOfWeek);

            case Schedule.Second:
                return GetNthWeekdayOfMonth(2, dayOfWeek);

            case Schedule.Third:
                return GetNthWeekdayOfMonth(3, dayOfWeek);

            case Schedule.Fourth:
                return GetNthWeekdayOfMonth(4, dayOfWeek);

            case Schedule.Last:
                return GetLastWeekdayOfMonth(dayOfWeek);

            default:
                throw new ArgumentOutOfRangeException(nameof(schedule));
        }
    }

    private DateTime GetNthWeekdayOfMonth(int n, DayOfWeek dayOfWeek)
    {
        if (n < 1 || n > 4)
            throw new ArgumentOutOfRangeException(nameof(n));

        var current = new DateTime(year, month, 1);
        var count = 0;

        while (count < n)
        {
            if (current.DayOfWeek == dayOfWeek)
                count++;
            if (count < n)
                current = current.AddDays(1);
        }

        return current;
    }

    private DateTime GetLastWeekdayOfMonth(DayOfWeek dayOfWeek)
    {
        var current = new DateTime(year, month, 1);
        DateTime lastOccurrence = DateTime.MinValue;

        while (current.Month == month)
        {
            if (current.DayOfWeek == dayOfWeek)
                lastOccurrence = current;

            current = current.AddDays(1);
        }

        return lastOccurrence;
    }
}
