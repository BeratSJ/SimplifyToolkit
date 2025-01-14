using System;

public class DateManager
{
    private int year;
    private int month;
    private int day;

    private static readonly int[] DaysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    public DateManager(int year, int month, int day)
    {
        if (month < 1 || month > 12)
            throw new ArgumentException("Month must be between 1 and 12.");
        if (day < 1 || day > GetDaysInMonth(year, month))
            throw new ArgumentException("Invalid day for the given month and year.");

        this.year = year;
        this.month = month;
        this.day = day;
    }

    public int Year => year;
    public int Month => month;
    public int Day => day;

 
    public static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    public static int GetDaysInMonth(int year, int month)
    {
        if (month == 2 && IsLeapYear(year))
            return 29;
        return DaysInMonths[month - 1];
    }

    
    public void NextDay()
    {
        day++;
        if (day > GetDaysInMonth(year, month))
        {
            day = 1;
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
        }
    }

    
    public void PreviousDay()
    {
        day--;
        if (day < 1)
        {
            month--;
            if (month < 1)
            {
                month = 12;
                year--;
            }
            day = GetDaysInMonth(year, month);
        }
    }

   
    public DateTime ToDateTime()
    {
        return new DateTime(year, month, day);
    }

  
    public static DateManager FromDateTime(DateTime dateTime)
    {
        return new DateManager(dateTime.Year, dateTime.Month, dateTime.Day);
    }

   
    public override bool Equals(object obj)
    {
        if (obj is DateManager other)
        {
            return year == other.year && month == other.month && day == other.day;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(year, month, day);
    }

  
    public override string ToString()
    {
        return $"{day:D2}.{month:D2}.{year}";
    }
}