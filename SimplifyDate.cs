using System;
using System.Globalization;
using System.Resources;

public class SimplifyDate
{
    public int Year { get; }
    public int Month { get; }
    public int Day { get; }

    private static readonly int[] DaysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    private SimplifyDate(int year, int month, int day)
    {
        if (month < 1 || month > 12)
            throw new DateException("InvalidMonth");

        int maxDays = GetDaysInMonth(year, month);
        if (day < 1 || day > maxDays)
            throw new DateException("InvalidDay");

        Year = year;
        Month = month;
        Day = day;
    }

    public static bool IsLeapYear(int year) => (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    public static int GetDaysInMonth(int year, int month) => month == 2 && IsLeapYear(year) ? 29 : DaysInMonths[month - 1];

    public DateTime ToDateTime() => new(Year, Month, Day);

    public static SimplifyDate FromDateTime(DateTime dt) => new(dt.Year, dt.Month, dt.Day);

    public static SimplifyDate Create(int year, int month, int day) => new(year, month, day);

    public override string ToString() => $"{Day:D2}.{Month:D2}.{Year}";
}

public class DateException : Exception
{
    public DateException(string message) : base(GetMessage(message)) { }

    private static string GetMessage(string key)
    {
        return key switch
        {
            "InvalidMonth" => "Month must be between 1 and 12.",
            "InvalidDay" => "The day exceeds the month's limit.",
            _ => "Unkwown Error."
        };
    }
}
