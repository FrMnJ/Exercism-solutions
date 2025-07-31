using System;
using System.Data;
using System.Globalization;
using System.Runtime.InteropServices;

public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    public static DateTime ShowLocalTime(DateTime dtUtc)
        => dtUtc.ToLocalTime();

    public static DateTime Schedule(string appointmentDateDescription, Location location)
    {
        var timeZone = TimeZoneInfo.FindSystemTimeZoneById(GetTimeZoneId(location));

        var localTime = DateTime.Parse(appointmentDateDescription);
        var utcTime = TimeZoneInfo.ConvertTimeToUtc(localTime, timeZone);
        return utcTime;
    }

    private static string GetTimeZoneId(Location location)
        => location switch
        {
            Location.NewYork => RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                ? "Eastern Standard Time"
                : "America/New_York",
            Location.London => RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
            ? "GMT Standard Time"
            : "Europe/London",
            Location.Paris => RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
            ? "W. Europe Standard Time"
            : "Europe/Paris",
            _ => throw new ArgumentOutOfRangeException(),
        };

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel)
        => alertLevel switch
        {
            AlertLevel.Early => appointment.AddDays(-1),
            AlertLevel.Standard => appointment.Add(new TimeSpan(-1, -45, 0)),
            AlertLevel.Late => appointment.AddMinutes(-30),
            _ => throw new ArgumentOutOfRangeException(nameof(alertLevel), "Must be a value of the enum AlertLevel"),
        };

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        var timeZone = TimeZoneInfo.FindSystemTimeZoneById(GetTimeZoneId(location));

        var appointment = TimeZoneInfo.ConvertTimeFromUtc(dt, timeZone);
        var sevenDaysAgo = appointment.AddDays(-7);

        bool appointmentIsDST = timeZone.IsDaylightSavingTime(appointment);
        bool pastIsDST = timeZone.IsDaylightSavingTime(sevenDaysAgo);

        return appointmentIsDST != pastIsDST;
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        CultureInfo culture = GetCulture(location);
        if (DateTime.TryParse(dtStr, culture, DateTimeStyles.None, out var dt))
        {
            return dt;
        }
        return DateTime.MinValue;
    }

    private static CultureInfo GetCulture(Location location)
        => location switch
        {
            Location.NewYork => new CultureInfo("en-US"),
            Location.London => new CultureInfo("en-GB"),
            Location.Paris => new CultureInfo("fr-FR"),
            _ => throw new ArgumentOutOfRangeException(nameof(location), "Must be a value in enum Location"),
        };
    
}
